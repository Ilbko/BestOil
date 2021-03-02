
using System.Collections.Generic;
using System.Windows.Forms;

namespace BestOil
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Text = "BestOil";

            #region Инициализация элементов первой группы
            group_station = new GroupBox();
            station_combo_fuel = new ComboBox();
            station_label_fuel_text = new Label();
            station_label_fuelprice = new Label();
            station_label_fuelprice_text = new Label();

            station_panel_radio = new Panel();
            station_radio_amount = new RadioButton();
            station_radio_sum = new RadioButton();

            station_textbox_amount = new TextBox();
            station_label_amount_text = new Label();
            station_textbox_sum = new TextBox();
            station_label_sum_text = new Label();

            station_group_payment = new GroupBox();
            station_label_payment = new Label();
            station_label_payment_text = new Label();
            #endregion

            #region Инициализация элементов второй группы
            group_cafe = new GroupBox();

            //cafe_check_food.ForEach(i => i = new CheckBox());

            //cafe_textbox_price.ForEach(i => i = new TextBox());
            cafe_label_price_text = new Label();

            //cafe_textbox_amount.ForEach(i => i = new TextBox());
            cafe_label_amount_text = new Label();

            cafe_group_payment = new GroupBox();
            cafe_label_payment = new Label();
            cafe_label_payment_text = new Label();
            #endregion

            #region Инициализация элементов третьей группы
            group_pay = new GroupBox();

            pay_picture = new PictureBox();

            pay_button = new Button();

            pay_label_payment = new Label();
            pay_label_payment_text = new Label();
            #endregion

            this.Load += Form_Load;
            this.FormClosing += Form_Closing;
        }

        #endregion

        /*Принцип наименования элементов:
          - Все элементы имеют в своём названии свой тип.
          - Элементы группы, принадлежащие какой-либо главной панели, в начале
            своего названия имеют имя панели.
          - Имя элементов указывает на их функцию/роль.
          - Если элемент, а именно Label, предназначен для неизменимого в роли программмы
            вывода текста (для описания действия какого-либо элемента), то в своём названии
            он имеет приставку "text".*/
        #region Первая группа элементов - "Автозаправка"
        GroupBox group_station;
        ComboBox station_combo_fuel;
            Label station_label_fuel_text;
        Label station_label_fuelprice;
            Label station_label_fuelprice_text;

        Panel station_panel_radio;
        RadioButton station_radio_amount;
        RadioButton station_radio_sum;

        TextBox station_textbox_amount;
            Label station_label_amount_text;
        TextBox station_textbox_sum;
            Label station_label_sum_text;

        GroupBox station_group_payment;
        Label station_label_payment;
            Label station_label_payment_text;
        #endregion

        #region Вторая группа элементов - "Кафе"
        GroupBox group_cafe;

        List<CheckBox> cafe_check_food = new List<CheckBox>(new CheckBox[4] {new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox()});

        List<TextBox> cafe_textbox_price = new List<TextBox>(new TextBox[4] {new TextBox(), new TextBox(), new TextBox(), new TextBox()});
            Label cafe_label_price_text;

        List<TextBox> cafe_textbox_amount = new List<TextBox>(new TextBox[4] {new TextBox(), new TextBox(), new TextBox(), new TextBox()});
            Label cafe_label_amount_text;

        GroupBox cafe_group_payment;
        Label cafe_label_payment;
        Label cafe_label_payment_text;
        #endregion

        #region Третья группа элементов - "Оплата"
        GroupBox group_pay;

        PictureBox pay_picture;

        Button pay_button;

        Label pay_label_payment;
            Label pay_label_payment_text;
        #endregion
    }
}

