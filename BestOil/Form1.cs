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
            station_combo_fuel.Items.AddRange(new string[] { "A-95", "A-92", "Дизель" });
            station_combo_fuel.SelectedIndexChanged += Combo_SelectedIndexChanged;
            station_combo_fuel.SelectedIndex = 0;

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
            station_radio_amount.Tag = 0;
            station_radio_amount.Checked = true;
            station_radio_amount.CheckedChanged += Radio_CheckedChanged;

            station_textbox_amount.Location = new Point(station_radio_amount.Location.X + station_textbox_amount.Size.Width + 30, 110);
            station_textbox_amount.Tag = 0;
            station_textbox_amount.Name = "0";
            station_textbox_amount.TextChanged += Station_TextBox_TextChanged;
            station_textbox_amount.EnabledChanged += Station_TextBox_EnabledChanged;

            station_radio_sum.Location = new Point(5, station_panel_radio.Size.Height - station_panel_radio.Size.Height / 8 - station_radio_sum.Size.Height);
            station_radio_sum.Text = "Сумма (грн.)";
            station_radio_sum.Tag = 1;

            station_textbox_sum.Location = new Point(station_radio_sum.Location.X + station_textbox_sum.Size.Width + 30, 150);
            station_textbox_sum.Enabled = false;
            station_textbox_sum.Tag = 1;
            station_textbox_sum.Name = "0";
            station_textbox_sum.TextChanged += Station_TextBox_TextChanged;
            station_textbox_sum.TextChanged += Station_TextBox_EnabledChanged;

            station_label_payment.Location = new Point(20, 20);
            station_label_payment.Size = new Size(station_group_payment.Size.Width - 60, station_group_payment.Size.Height - 40);
            station_label_payment.Font = new Font(FontFamily.GenericSansSerif, 30);
            station_label_payment.TextAlign = ContentAlignment.MiddleRight;
            station_label_payment.Text = "0,00";

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
            cafe_label_payment.TextAlign = ContentAlignment.MiddleRight;
            cafe_label_payment.Text = "0,00";

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
            cafe_check_food.ForEach(i => i.CheckedChanged += CheckBox_CheckedChanged);

            loc.X = group_cafe.Size.Width / 2;
            loc.Y = 30;

            cafe_textbox_price.ForEach(i => i.Location = new Point(loc.X, loc.Y += 30));
            cafe_textbox_price.ForEach(i => i.Size = new Size(50, i.Size.Height));
            cafe_textbox_price.ForEach(i => i.Enabled = false);
            cafe_textbox_price[0].Text = "4,00";
            cafe_textbox_price[1].Text = "5,40";
            cafe_textbox_price[2].Text = "7,20";
            cafe_textbox_price[3].Text = "4,40";

            cafe_label_price_text.Location = new Point(cafe_textbox_price[0].Location.X, cafe_textbox_price[0].Location.Y - 30);
            cafe_label_price_text.Text = "Цена";
            cafe_label_price_text.Size = new Size(40, cafe_label_price_text.Size.Height);

            loc.X = group_cafe.Size.Width / 2 + cafe_textbox_price[0].Size.Width + 10;
            loc.Y = 30;

            cafe_textbox_amount.ForEach(i => i.Location = new Point(loc.X, loc.Y += 30));
            cafe_textbox_amount.ForEach(i => i.Size = new Size(50, i.Size.Height));
            cafe_textbox_amount.ForEach(i => i.Text = "0");
            cafe_textbox_amount.ForEach(i => i.Enabled = false);
            cafe_textbox_amount.ForEach(i => i.TextChanged += Cafe_TextBox_TextChanged);
            cafe_textbox_amount.ForEach(i => i.EnabledChanged += Cafe_TextBox_EnabledChanged);
            cafe_textbox_amount.ForEach(i => i.Name = "0");

            cafe_textbox_amount[0].Tag = 0;
            cafe_textbox_amount[1].Tag = 1;
            cafe_textbox_amount[2].Tag = 2;
            cafe_textbox_amount[3].Tag = 3;

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

            pay_picture.Image = Image.FromFile(@"C:\Users\Илья\source\repos\WinForms_Homework\(8)BestOil\dollar.png");
            pay_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            pay_picture.Size = new Size(40, 40);
            pay_picture.Location = new Point(20, 20);

            pay_button.Size = new Size(100, 50);
            pay_button.Text = "Рассчитать";
            pay_button.Location = new Point(150, 20);

            pay_label_payment.Size = new Size(180, 60);
            pay_label_payment.Location = new Point(group_pay.Size.Width - pay_label_payment.Size.Width - 50, 20);
            pay_label_payment.Font = new Font(FontFamily.GenericSansSerif, 30);
            pay_label_payment.TextAlign = ContentAlignment.MiddleRight;
            pay_label_payment.Text = "0,00";
            
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

        public void CheckBox_CheckedChanged(object sender, EventArgs argv)
        {
            if ((sender as CheckBox).Text == "Хот-дог" && cafe_textbox_amount[0].Enabled == false)
            {
                cafe_textbox_amount[0].Enabled = true;
            }
            else if ((sender as CheckBox).Text == "Хот-дог") 
            {
                cafe_textbox_amount[0].Enabled = false;
            }

            if ((sender as CheckBox).Text == "Гамбургер" && cafe_textbox_amount[1].Enabled == false)
            {
                cafe_textbox_amount[1].Enabled = true;
            }
            else if ((sender as CheckBox).Text == "Гамбургер")
            {
                cafe_textbox_amount[1].Enabled = false;
            }

            if ((sender as CheckBox).Text == "Картошка-фри" && cafe_textbox_amount[2].Enabled == false)
            {
                cafe_textbox_amount[2].Enabled = true;
            }
            else if ((sender as CheckBox).Text == "Картошка-фри")
            {
                cafe_textbox_amount[2].Enabled = false;
            }

            if ((sender as CheckBox).Text == "Кока-кола" && cafe_textbox_amount[3].Enabled == false)
            {
                cafe_textbox_amount[3].Enabled = true;
            }
            else if ((sender as CheckBox).Text == "Кока-кола")
            {
                cafe_textbox_amount[3].Enabled = false;
            }
        }

        public void Cafe_TextBox_TextChanged(object sender, EventArgs argv)
        {
            double result = double.Parse(cafe_label_payment.Text);

            if ((sender as TextBox).Enabled == true)
            {
                result -= double.Parse((sender as TextBox).Name) * double.Parse(cafe_textbox_price[(int)(sender as TextBox).Tag].Text);
                result += double.Parse((sender as TextBox).Text) * double.Parse(cafe_textbox_price[(int)(sender as TextBox).Tag].Text);
                cafe_label_payment.Text = result.ToString();

                (sender as TextBox).Name = (sender as TextBox).Text;
            }
        }

        public void Cafe_TextBox_EnabledChanged(object sender, EventArgs argv)
        {
            double result = double.Parse(cafe_label_payment.Text);

            if ((sender as TextBox).Enabled == false)
            {
                result -= double.Parse((sender as TextBox).Text) * double.Parse(cafe_textbox_price[(int)(sender as TextBox).Tag].Text);
                cafe_label_payment.Text = result.ToString();
            }
            else if ((sender as TextBox).Enabled == true)
            {
                result += double.Parse((sender as TextBox).Text) * double.Parse(cafe_textbox_price[(int)(sender as TextBox).Tag].Text);
                cafe_label_payment.Text = result.ToString();
            }
        }

        public void Combo_SelectedIndexChanged(object sender, EventArgs argv)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0:
                    {
                        station_label_fuelprice.Text = "28,22";
                        break;
                    }
                case 1:
                    {
                        station_label_fuelprice.Text = "27,21";
                        break;
                    }
                case 2:
                    {
                        station_label_fuelprice.Text = "27,63";
                        break;
                    }
            }
        }

        public void Radio_CheckedChanged(object sender, EventArgs argv)
        {
            if ((int)(sender as RadioButton).Tag == 0 && (sender as RadioButton).Checked == false)
            {
                station_group_payment.Text = "К выдаче";
                station_label_payment_text.Text = "л.";

                station_textbox_amount.Enabled = false;
                station_textbox_sum.Enabled = true;
            }
            else if ((int)(sender as RadioButton).Tag == 0 && (sender as RadioButton).Checked == true)
            {
                station_group_payment.Text = "К оплате";
                station_label_payment_text.Text = "грн.";

                station_textbox_amount.Enabled = true;
                station_textbox_sum.Enabled = false;
            }
        }

        public void Station_TextBox_TextChanged(object sender, EventArgs argv)
        {
            double result = double.Parse(station_label_payment.Text);

            if ((int)(sender as TextBox).Tag == 0)
            {
                result -= double.Parse((sender as TextBox).Name) * double.Parse(station_label_fuelprice.Text);
                result += double.Parse((sender as TextBox).Text) * double.Parse(station_label_fuelprice.Text);
                station_label_payment.Text = result.ToString();

                (sender as TextBox).Name = (sender as TextBox).Text;
            }
            else if ((int)(sender as TextBox).Tag == 1)
            {
                result -= double.Parse((sender as TextBox).Name) / double.Parse(station_label_fuelprice.Text);
                result += double.Parse((sender as TextBox).Text) / double.Parse(station_label_fuelprice.Text);
                station_label_payment.Text = result.ToString();

                (sender as TextBox).Name = (sender as TextBox).Text;
            }
        }

        public void Station_TextBox_EnabledChanged(object sender, EventArgs argv)
        {
            double result = double.Parse(station_label_payment.Text);

            if ((int)(sender as TextBox).Tag == 0)
            {
                if ((sender as TextBox).Enabled == false)
                {
                    result = 0;
                    station_textbox_sum.Text = "0";
                    station_textbox_amount.Text = "0";
                    station_label_payment.Text = result.ToString();
                }
                else if ((sender as TextBox).Enabled == true)
                {
                    result = 0;
                    station_textbox_amount.Text = "0";
                    station_textbox_sum.Text = "0";
                    station_label_payment.Text = result.ToString();
                }
            }
        }
    }
}
