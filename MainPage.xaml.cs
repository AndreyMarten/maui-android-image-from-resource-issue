using System.Collections.ObjectModel;

namespace MauiApp8;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = this;
	}


    protected ObservableCollection<Item> _Items;
    public ObservableCollection<Item> Items
    {
        get
        {
            if (this._Items == null)
            {
                this._Items = new ObservableCollection<Item>();
            }

            return this._Items;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Items.Clear();
        this.Items.Add(new Item() { Image = ImageSource.FromResource("MauiApp8.Resources.Images.refresh.png") });
        this.Items.Add(new Item() { Image = ImageSource.FromResource("MauiApp8.Resources.Images.remove.png") });
    }
}

