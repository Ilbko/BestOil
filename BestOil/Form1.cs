using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        public struct Loc
        {
            public int X;
            public int Y;
        }

        public void FirstGroup_Init()
        {
            #region Работа с элементами первой группы
            station_group_payment.Controls.AddRange(new Control[] {station_label_payment,
                                                                   station_label_payment_text});
            station_panel_radio.Controls.AddRange(new Control[] {station_radio_amount,
                                                                 station_radio_sum});
            group_station.Controls.AddRange(new Control[] {station_group_payment,
                                                           station_panel_radio});
        
            group_station.Controls.AddRange(new Control[] {station_combo_fuel,
                                                           station_label_fuel_text,
                                                           station_label_fuelprice,
                                                           station_label_fuelprice_text,
                                                           station_textbox_amount,
                                                           station_textbox_sum});

            group_station.Size = new Size(250, 300);
            group_station.Location = new Point(20, 20);
            group_station.Text = "Автозаправка";
            
            station_group_payment.Location = new Point(5, group_station.Size.Height - station_group_payment.Size.Height - 5);
            station_group_payment.Size = new Size(group_station.Size.Width - 10, station_group_payment.Height);
            station_group_payment.Text = "К оплате";

            station_combo_fuel.Location = new Point(80, 20);

            station_label_fuel_text.Location = new Point(10, 20);
            station_label_fuel_text.Text = "Бензин";

            station_label_fuelprice.Location = new Point(80, 60);
            station_label_fuelprice.Size = station_combo_fuel.Size;

            station_label_fuelprice_text.Location = new Point(10, 60);
            station_label_fuelprice_text.Text = "Цена (грн)";

            station_panel_radio.Location = new Point(10, group_station.Size.Height / 2 - 50);
            station_panel_radio.Size = new Size(group_station.Size.Width / 2 - 20, 80);
            station_panel_radio.BorderStyle = BorderStyle.Fixed3D;           

            station_radio_amount.Location = new Point(5, station_panel_radio.Size.Height / 8);
            station_radio_amount.Text = "Количество (л)";

            station_textbox_amount.Location = new Point(station_radio_amount.Location.X + station_textbox_amount.Size.Width + 30, 110);

            station_radio_sum.Location = new Point(5, station_panel_radio.Size.Height - station_panel_radio.Size.Height / 8 - station_radio_sum.Size.Height);
            station_radio_sum.Text = "Сумма (грн.)";

            station_textbox_sum.Location = new Point(station_radio_sum.Location.X + station_textbox_sum.Size.Width + 30, 150);

            station_label_payment.Location = new Point(20, 20);
            station_label_payment.Size = new Size(station_group_payment.Size.Width - 60, station_group_payment.Size.Height - 40);
            station_label_payment.Font = new Font(FontFamily.GenericSansSerif, 30);
            station_label_payment.Text = "ТЕСТ";

            station_label_payment_text.Size = new Size(30, 20);
            station_label_payment_text.Location = new Point(station_label_payment.Size.Width + 20, station_label_payment.Location.Y);
            station_label_payment_text.Text = "грн.";

            this.Controls.Add(group_station);
            #endregion
        }
        public void SecondGroup_Init()
        {
            #region Работа с элементами второй группы
            cafe_group_payment.Controls.AddRange(new Control[] {cafe_label_payment,
                                                                cafe_label_payment_text});
            group_cafe.Controls.Add(cafe_group_payment);

            cafe_check_food.ForEach(i => group_cafe.Controls.Add(i));

            cafe_textbox_price.ForEach(i => group_cafe.Controls.Add(i));
            cafe_textbox_amount.ForEach(i => group_cafe.Controls.Add(i));
            group_cafe.Controls.AddRange(new Control[] {cafe_label_price_text,
                                                        cafe_label_amount_text});

            group_cafe.Size = new Size(250, 300);
            group_cafe.Location = new Point(this.ClientSize.Width - group_cafe.Size.Width - 20, 20);
            group_cafe.Text = "Мини-Кафе";

            cafe_group_payment.Location = new Point(5, group_cafe.Size.Height - cafe_group_payment.Size.Height - 5);
            cafe_group_payment.Size = new Size(group_cafe.Size.Width - 10, cafe_group_payment.Height);
            cafe_group_payment.Text = "К оплате";

            cafe_label_payment.Location = new Point(20, 20);
            cafe_label_payment.Size = new Size(cafe_group_payment.Size.Width - 60, cafe_group_payment.Size.Height - 40);
            cafe_label_payment.Font = new Font(FontFamily.GenericSansSerif, 30);
            cafe_label_payment.Text = "ТЕСТ";

            cafe_label_payment_text.Size = new Size(30, 20);
            cafe_label_payment_text.Location = new Point(cafe_label_payment.Size.Width + 20, cafe_label_payment.Location.Y);
            cafe_label_payment_text.Text = "грн.";

            Loc loc;
            loc.X = 5;
            loc.Y = 30;

            cafe_check_food[0].Text = "Хот-дог";
            cafe_check_food[1].Text = "Гамбургер";
            cafe_check_food[2].Text = "Картошка-фри";
            cafe_check_food[3].Text = "Кока-кола";

            cafe_check_food.ForEach(i => i.Location = new Point(loc.X, loc.Y += 30));

            loc.X = group_cafe.Size.Width / 2;
            loc.Y = 30;

            cafe_textbox_price.ForEach(i => i.Location = new Point(loc.X, loc.Y += 30));
            cafe_textbox_price.ForEach(i => i.Size = new Size(50, i.Size.Height));

            cafe_label_price_text.Location = new Point(cafe_textbox_price[0].Location.X, cafe_textbox_price[0].Location.Y - 30);
            cafe_label_price_text.Text = "Цена";
            cafe_label_price_text.Size = new Size(40, cafe_label_price_text.Size.Height);

            loc.X = group_cafe.Size.Width / 2 + cafe_textbox_price[0].Size.Width + 10;
            loc.Y = 30;

            cafe_textbox_amount.ForEach(i => i.Location = new Point(loc.X, loc.Y += 30));
            cafe_textbox_amount.ForEach(i => i.Size = new Size(50, i.Size.Height));

            cafe_label_amount_text.Location = new Point(cafe_textbox_amount[0].Location.X, cafe_textbox_amount[0].Location.Y - 30);
            cafe_label_amount_text.Text = "Кол.";
            cafe_label_amount_text.Size = new Size(40, cafe_label_amount_text.Size.Height);

            this.Controls.Add(group_cafe);

            #endregion
        }

        public void ThirdGroup_Init()
        {
            #region Работа с элементами третьей группы
            group_pay.Controls.AddRange(new Control[] {pay_picture, 
                                                       pay_button, 
                                                       pay_label_payment, 
                                                       pay_label_payment_text});

            group_pay.Size = new Size(this.ClientSize.Width - 40, 90);
            group_pay.Location = new Point(group_station.Location.X, group_station.Location.Y + group_station.Size.Height + 20);
            group_pay.Text = "Всего к оплате";

            pay_picture.Image = Image.FromFile(@"C:\Users\Илья\source\repos\WinForms_Homework\BestOil\dollar.png");
            pay_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            pay_picture.Size = new Size(40, 40);
            pay_picture.Location = new Point(20, 20);

            pay_button.Size = new Size(100, 50);
            pay_button.Text = "Рассчитать";
            pay_button.Location = new Point(150, 20);

            pay_label_payment.Size = new Size(180, 60);
            pay_label_payment.Location = new Point(group_pay.Size.Width - pay_label_payment.Size.Width - 50, 20);
            pay_label_payment.Font = new Font(FontFamily.GenericSansSerif, 30);
            pay_label_payment.Text = "ТЕСТ";
            
            pay_label_payment_text.Size = new Size(30, 20);
            pay_label_payment_text.Location = new Point(group_pay.Size.Width - 50, 20);
            pay_label_payment_text.Text = "грн.";

            this.Controls.Add(group_pay);
            #endregion
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form_Load(object sender, EventArgs argv)
        {
            FirstGroup_Init();
            SecondGroup_Init();
            ThirdGroup_Init();
        }
    }
}
