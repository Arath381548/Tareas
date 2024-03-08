namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private string currentPlayer = "X";
        private Button[] buttons;
        int turno = 0;
        int PtoX = 0;


        //Implementa los botones agregados en MainPage.xaml
        public MainPage()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        //Metodo de comprobacion de victorias
        async public void comprobar()
        {
            //Comprobacion de victoria del jugador 1 (jose)
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||

                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||

                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                //Agrega punto al jugador 1 (jose)
                PtoX++;
                PtO.Text = "O - " + Convert.ToString(PtoX);
                //Alerta de humillacion de victoria
                await DisplayAlert("BARABROOOOO", "Jugador 1 Humillo al tercermundista del contrincante", "Ok");

                //elimina la posibilidad de apretar mas botones tras la victoria
                button1.IsEnabled = false;
                button2.IsEnabled = false;
                button3.IsEnabled = false;
                button4.IsEnabled = false;
                button5.IsEnabled = false;
                button6.IsEnabled = false;
                button7.IsEnabled = false;
                button8.IsEnabled = false;
                button9.IsEnabled = false;
            }
            //Comprobacion de victoria del jugador 2 (juana)
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||

                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||

                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {

                //Agrega punto al jugador 1 (jose) y llama la alerta ayuilio para mostrar en la pantalla
                PtoX++;
                PtX.Text = "X - " + Convert.ToString(PtoX);
                auyilio();
            }
        }
        //funcion de turnos entre la x y o asi como la desactivacion del boton precionado
        async void Button_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (turno == 0)
            {
                button.Text = "O";
                button.IsEnabled = false;
                comprobar();
                turno = 1;

            }

            else if (turno == 1)
            {
                button.Text = "X";
                button.IsEnabled = false;
                comprobar();
                turno = 0;

            }
        }
        //funcion ayuilio (alerta de victoria en caso de juana) y desactivacion de botones restantes
        async private void auyilio()
        {
            await DisplayAlert("BARABROOOOO", "Jugador 2 Humillo al tercermundista del contrincante", "Ok");
            button1.IsEnabled = false;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false;
        }


    }
}
