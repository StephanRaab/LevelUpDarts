using LevelUpDarts.ViewModel;

namespace LevelUpDarts;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
