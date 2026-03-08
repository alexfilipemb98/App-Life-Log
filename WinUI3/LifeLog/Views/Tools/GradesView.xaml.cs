using LifeLog.Core.Utils.Items;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace LifeLog.Views.Tools;

public sealed partial class GradesView : UserControl
{
    public ObservableCollection<GradeItem> Grades { get; set; } = new ObservableCollection<GradeItem>();

    public GradesView()
    {
        InitializeComponent();
        
        GradesList.ItemsSource = Grades;

        AddRow();
    }


    private void AddRowBtn_Click(object sender, RoutedEventArgs e) => AddRow();

    private void DeleteRow_Click(object sender, RoutedEventArgs e)
    {
        // Descobre qual o item que clic�mos para apagar
        var btn = sender as Button;
        var item = btn?.DataContext as GradeItem;

        if (item != null)
        {
            Grades.Remove(item);
            CalculateFinalGrade();
        }
    }

    #region FUNCTIONS


    private void AddRow()
    {
        var newItem = new GradeItem { Name = "New Assessment", Grade = 0, Weight = 0 };

        // Subscrevemos �s mudan�as de cada item para atualizar a m�dia em tempo real
        newItem.PropertyChanged += (s, e) => CalculateFinalGrade();

        Grades.Add(newItem);
        CalculateFinalGrade();
    }

    /// <summary>
    /// Calculate the grades
    /// </summary>
    private void CalculateFinalGrade()
    {
        if (Grades == null || !Grades.Any())
        {
            FinalGradeRoundedLabel.Text = "0";
            FinalGradeDecimalLabel.Text = "0.00";
            StatusLabel.Text = "WAITING";
            return;
        }

        double totalWeight = Grades.Sum(x => x.Weight);
        double weightedSum = Grades.Sum(x => x.Grade * x.Weight);

        WeightWarning.IsOpen = Math.Abs(totalWeight - 100.0) > 0.01;

        if (totalWeight > 0)
        {
            double realAverage = weightedSum / totalWeight;

            // 1. Nota Decimal com 2 casas (F2)
            FinalGradeDecimalLabel.Text = realAverage.ToString("F2");

            // 2. Nota Arredondada a 0 casas (Cima/Baixo conforme o 0.5)
            double rounded = Math.Round(realAverage, 0, MidpointRounding.AwayFromZero);
            FinalGradeRoundedLabel.Text = rounded.ToString("0");

            // 3. Status (baseado na regra dos 9.5)
            if (realAverage >= 9.5)
            {
                StatusLabel.Text = "APPROVED";
                StatusBorder.Opacity = 0.5; // Mais vis�vel
            }
            else
            {
                StatusLabel.Text = "REPROVED";
                StatusBorder.Opacity = 0.2;
            }
        }
    }

    #endregion
}
