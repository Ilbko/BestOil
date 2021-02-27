
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "BestOil";
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
        Panel panel_station;
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

        Panel station_panel_payment;
        Label station_label_payment;
            Label station_label_payment_text;
        #endregion
    }
}

