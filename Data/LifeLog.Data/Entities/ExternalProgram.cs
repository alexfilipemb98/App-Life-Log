using DevExpress.Utils.Svg;
using LifeLog.Core.Enums;
using LifeLog.Core.Utils;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace LifeLog.Data.Entities;

[Table("ExternalPrograms")]
[Description("Database model for external programs")]
public partial class ExternalProgram
{
    #region PROPERTIES

    [Key]
    public Guid? Id { get; set; }

    [DataType(DataType.Text)]
    [Core.Attributes.Required]
    [Core.Attributes.StringLength(30, MinimumLength = 3)]
    public string? Name { get; set; }

    [DataType(DataType.Text)]
    [Core.Attributes.Required]
    [Core.Attributes.StringLength(5)]
    public string? FileExtension { get; set; }

    [DataType(DataType.Text)]
    [Core.Attributes.Required]
    [Core.Attributes.StringLength(400)]
    public string? PathToProgram { get; set; }

    [DataType(DataType.Text)]
    [Core.Attributes.StringLength(150)]
    public string? Arguments { get; set; }

    public byte[]? ImageData { get; set; }

    [DataType(DataType.Text)]
    [Core.Attributes.RequiredIf(nameof(HasImage), OperatorsEnum.Equal, true)]
    [Core.Attributes.StringLength(10)]
    public string? ImageExtension { get; set; }

    #endregion

    #region NOT MAPPED

    [JsonIgnore]
    [NotMapped]
    public bool IsImageSvg => ImageExtension == null ? false : ImageExtension.EndsWith("svg", System.StringComparison.InvariantCultureIgnoreCase);

    [JsonIgnore]
    [NotMapped]
    public SvgImage? SvgImage => HasImage && IsImageSvg ? ImagesUtil.ArrayToSvgImage(ImageData!) : null;

    [JsonIgnore]
    [NotMapped]
    public Bitmap? BitImage => HasImage && !IsImageSvg ? ImagesUtil.ArrayToBitmap(ImageData!) : null;

    [NotMapped]
    [JsonIgnore]
    public bool HasImage => ImageData != null && ImageData.Length > 0;

    [NotMapped]
    [JsonIgnore]
    private dynamic? fIcon;
    public dynamic? Icon
    {
        get
        {
            if (fIcon is null)
                return SvgImage is null ? BitImage : SvgImage;
            else
                return fIcon;
        }
        set
        {
            fIcon = value;
        }
    }

    #endregion
}
