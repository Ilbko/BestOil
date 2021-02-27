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

            station_combo_fuel.Location = new Point(70, 20);

            station_label_fuel_text.Location = new Point(10, 20);
            station_label_fuel_text.Text = "Бензин";

            station_label_fuelprice.Location = new Point(70, 60);
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
            station_label_payment.Size = new Size(station_group_payment.Size.Width - 60, station_group_payment.Size.Height - 30);
            station_label_payment.Font = new Font(FontFamily.GenericSansSerif, 30);
            station_label_payment.Text = "ТЕСТ";

            station_label_payment_text.Size = new Size(30, 20);
            station_label_payment_text.Location = new Point(station_label_payment.Size.Width + 20, station_label_payment.Location.Y);
            station_label_payment_text.Text = "грн.";

            this.Controls.Add(group_station);
            #endregion
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void Form_Load(object sender, EventArgs argv)
        {
            FirstGroup_Init();
        }
    }
}
