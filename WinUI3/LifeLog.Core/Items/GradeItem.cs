using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LifeLog.Core.Items;

public class GradeItem : INotifyPropertyChanged
{
    private string _name = "New Assessment";
    private double _grade = 0;
    private double _weight = 0;

    public event PropertyChangedEventHandler PropertyChanged;

    public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
    public double Grade { get => _grade; set { _grade = value; OnPropertyChanged(); } }
    public double Weight { get => _weight; set { _weight = value; OnPropertyChanged(); } }
    
    protected void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}