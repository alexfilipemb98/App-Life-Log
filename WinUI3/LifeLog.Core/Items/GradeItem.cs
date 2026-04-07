using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LifeLog.Core.Items;

public class GradeItem : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string _name = "New Assessment";
    public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
    
    private double _grade = 0;
    public double Grade { get => _grade; set { _grade = value; OnPropertyChanged(); } }
    
    private double _weight = 0;
    public double Weight { get => _weight; set { _weight = value; OnPropertyChanged(); } }
    
    protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}