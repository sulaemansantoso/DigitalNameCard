using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigitalNameCard2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            for (int i = 0; i < 57; i++)
            {
                RowDefinition r = new RowDefinition();
                r.Height = GridLength.Star;
                root.RowDefinitions.Add(r);
            }

            for (int i = 0; i < 30; i++)
            {
                ColumnDefinition c = new ColumnDefinition();
                c.Width = GridLength.Star;
                root.ColumnDefinitions.Add(c);
            }

            //CardLabel name = new CardLabel(20, 15, 3, 15, NamedSize.Large, TextAlignment.Center);
            //name.Text = "John Wick";

            //Grid g = new Grid();

            //g.SetValue(Grid.RowProperty, 0);
            //g.SetValue(Grid.ColumnProperty, 0);
            //g.SetValue(Grid.RowSpanProperty, 10);
            //g.SetValue(Grid.ColumnSpanProperty, 10);

            //g.BackgroundColor = Color.Red;

            //CardLabel title = new CardLabel(23, 15, 3, 15, NamedSize.Medium, TextAlignment.Center);
            //title.Text = "Head Programmer";

            //root.Children.Add(name.Label);
            //root.Children.Add(title.Label);

            //root.Children.Add(g);

            NameCard card = NameCard.CreateCardDesign(1);
            card.SetNameCard(root, background, "John Doe", "- Main Photographer -", "www.johndoephotography.com", "+6281233344455", "john.doe@johndoephotography.com", "Jl. Dago 999, Bandung, Indonesia");
        }
	}
}
