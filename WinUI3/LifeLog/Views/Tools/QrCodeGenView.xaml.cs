using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using QRCoder;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;

namespace LifeLog.Views.Tools;

public sealed partial class QrCodeGenView : UserControl
{
    private byte[] _currentQrCodePngBytes;

    public QrCodeGenView() => this.InitializeComponent();

    private void TypeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Garante que a UI já carregou
        if (PanelLink == null) return;

        // Esconde todos
        PanelLink.Visibility = Visibility.Collapsed;
        PanelText.Visibility = Visibility.Collapsed;
        PanelWiFi.Visibility = Visibility.Collapsed;
        PanelBarcode.Visibility = Visibility.Collapsed;

        // Descobre qual foi selecionado
        if (TypeSelector.SelectedItem is RadioButton selectedRadio)
        {
            string tag = selectedRadio.Tag.ToString();
            switch (tag)
            {
                case "Link": PanelLink.Visibility = Visibility.Visible; break;
                case "Text": PanelText.Visibility = Visibility.Visible; break;
                case "WiFi": PanelWiFi.Visibility = Visibility.Visible; break;
                case "Barcode": PanelBarcode.Visibility = Visibility.Visible; break;
            }
        }
    }

    // 2. GERAR O QR CODE
    private async void GenerateBtn_Click(object sender, RoutedEventArgs e)
    {
        string payloadText = "";

        string selectedType = (TypeSelector.SelectedItem as RadioButton)?.Tag.ToString();

        switch (selectedType)
        {
            case "Link":
                if (string.IsNullOrWhiteSpace(InputLink.Text)) return;

                PayloadGenerator.Url generatorUrl = new PayloadGenerator.Url(InputLink.Text);
                payloadText = generatorUrl.ToString();
                break;

            case "Text":
                if (string.IsNullOrWhiteSpace(InputText.Text)) return;
                payloadText = InputText.Text;
                break;

            case "WiFi":
                if (string.IsNullOrWhiteSpace(WifiSSID.Text)) return;

                PayloadGenerator.WiFi.Authentication auth = PayloadGenerator.WiFi.Authentication.WPA;
                if (WifiEncryption.SelectedIndex == 1) auth = PayloadGenerator.WiFi.Authentication.WEP;
                if (WifiEncryption.SelectedIndex == 2) auth = PayloadGenerator.WiFi.Authentication.nopass;

                PayloadGenerator.WiFi generatorWifi = new PayloadGenerator.WiFi(WifiSSID.Text, WifiPass.Password, auth);
                payloadText = generatorWifi.ToString();
                break;

            case "Barcode":
                // Nota: O QRCoder gera QR Codes e não código de barras 1D (linhas). 
                // Aqui estamos a gerar um QR Code que contém o número do Barcode.
                if (string.IsNullOrWhiteSpace(BarcodeValue.Text)) return;
                payloadText = BarcodeValue.Text;
                break;
        }

        // Se houver texto válido, cria a imagem!
        if (!string.IsNullOrEmpty(payloadText))
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                // ECCLevel.Q = Qualidade alta (permite que o código seja lido mesmo que falte um bocadinho)
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(payloadText, QRCodeGenerator.ECCLevel.Q))
                {
                    // Gera o QR Code diretamente em formato PNG
                    using (PngByteQRCode qrCode = new PngByteQRCode(qrCodeData))
                    {
                        // 20 é o tamanho dos pixeis (resolução da imagem final)
                        _currentQrCodePngBytes = qrCode.GetGraphic(20);
                    }
                }
            }

            // Exibe a imagem na Interface WinUI 3
            await ShowQrCodeInUi(_currentQrCodePngBytes);

            // Esconde o ícone cinzento e mostra a imagem no fundo branco
            PlaceholderIcon.Visibility = Visibility.Collapsed;
            ImageContainer.Visibility = Visibility.Visible;

            // Ativa os botões de Copiar e Guardar
            CopyBtn.IsEnabled = true;
            SaveBtn.IsEnabled = true;
        }
    }

    // Função auxiliar para converter o Array de Bytes num BitmapImage que o WinUI 3 entende
    private async Task ShowQrCodeInUi(byte[] imageBytes)
    {
        using InMemoryRandomAccessStream stream = new();
        using (DataWriter writer = new(stream.GetOutputStreamAt(0)))
        {
            writer.WriteBytes(imageBytes);
            await writer.StoreAsync();
        }

        BitmapImage image = new BitmapImage();
        await image.SetSourceAsync(stream);
        CodeImage.Source = image;
    }

    private async void CopyBtn_Click(object sender, RoutedEventArgs e)
    {
        if (_currentQrCodePngBytes == null) return;

        // Criamos um ficheiro temporário na memória para copiar como imagem
        InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream();
        await stream.WriteAsync(_currentQrCodePngBytes.AsBuffer());
        stream.Seek(0);

        DataPackage dataPackage = new DataPackage();
        dataPackage.SetBitmap(RandomAccessStreamReference.CreateFromStream(stream));
        Clipboard.SetContent(dataPackage);

        // Feedback Visual
        var originalContent = CopyBtn.Content;
        CopyBtn.Content = new StackPanel
        {
            Orientation = Orientation.Horizontal,
            Spacing = 8,
            Children = {
                new FontIcon { Glyph = "\uE8FB", FontFamily = new Microsoft.UI.Xaml.Media.FontFamily("Segoe Fluent Icons"), Foreground = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.LightGreen) },
                new TextBlock { Text = "Copied!", FontWeight = Microsoft.UI.Text.FontWeights.Medium }
            }
        };
        await Task.Delay(1500);
        CopyBtn.Content = originalContent;
    }

    private async void SaveBtn_Click(object sender, RoutedEventArgs e)
    {
        if (_currentQrCodePngBytes == null) return;

        FileSavePicker savePicker = new FileSavePicker();
        Window? window = (Application.Current as App)?.m_window;
        if (window != null)
        {
            WinRT.Interop.InitializeWithWindow.Initialize(savePicker, WinRT.Interop.WindowNative.GetWindowHandle(window));
        }

        savePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
        savePicker.FileTypeChoices.Add("PNG Image", new System.Collections.Generic.List<string>() { ".png" });
        savePicker.SuggestedFileName = "LifeLog_QRCode";

        StorageFile file = await savePicker.PickSaveFileAsync();

        if (file != null)
            await FileIO.WriteBytesAsync(file, _currentQrCodePngBytes);

    }
}