
namespace ClientTest
{
    partial class Main_FormClient
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
            this.Label_description = new System.Windows.Forms.Label();
            this.Label_IP_Adress = new System.Windows.Forms.Label();
            this.Label_Port = new System.Windows.Forms.Label();
            this.SET_IP_Adress_Server = new System.Windows.Forms.TextBox();
            this.SET_Port_Server = new System.Windows.Forms.TextBox();
            this.Label_message = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.TextBox_IncomigMessages = new System.Windows.Forms.TextBox();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.Timer_Sending_a_message = new System.Windows.Forms.Timer(this.components);
            this.Button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_description
            // 
            this.Label_description.AutoSize = true;
            this.Label_description.Location = new System.Drawing.Point(12, 9);
            this.Label_description.Name = "Label_description";
            this.Label_description.Size = new System.Drawing.Size(416, 13);
            this.Label_description.TabIndex = 0;
            this.Label_description.Text = "Клиентская часть программы тестирования прохождения TCP сетевых пакетов";
            // 
            // Label_IP_Adress
            // 
            this.Label_IP_Adress.AutoSize = true;
            this.Label_IP_Adress.Location = new System.Drawing.Point(12, 36);
            this.Label_IP_Adress.Name = "Label_IP_Adress";
            this.Label_IP_Adress.Size = new System.Drawing.Size(110, 13);
            this.Label_IP_Adress.TabIndex = 1;
            this.Label_IP_Adress.Text = "IP v4 адрес сервера";
            // 
            // Label_Port
            // 
            this.Label_Port.AutoSize = true;
            this.Label_Port.Location = new System.Drawing.Point(260, 36);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(77, 13);
            this.Label_Port.TabIndex = 2;
            this.Label_Port.Text = "Порт сервера";
            // 
            // SET_IP_Adress_Server
            // 
            this.SET_IP_Adress_Server.Location = new System.Drawing.Point(128, 33);
            this.SET_IP_Adress_Server.Name = "SET_IP_Adress_Server";
            this.SET_IP_Adress_Server.Size = new System.Drawing.Size(126, 20);
            this.SET_IP_Adress_Server.TabIndex = 3;
            // 
            // SET_Port_Server
            // 
            this.SET_Port_Server.Location = new System.Drawing.Point(357, 33);
            this.SET_Port_Server.Name = "SET_Port_Server";
            this.SET_Port_Server.Size = new System.Drawing.Size(61, 20);
            this.SET_Port_Server.TabIndex = 4;
            // 
            // Label_message
            // 
            this.Label_message.AutoSize = true;
            this.Label_message.Location = new System.Drawing.Point(12, 64);
            this.Label_message.Name = "Label_message";
            this.Label_message.Size = new System.Drawing.Size(65, 13);
            this.Label_message.TabIndex = 7;
            this.Label_message.Text = "Соббщение";
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(113, 64);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(305, 20);
            this.MessageText.TabIndex = 8;
            this.MessageText.Text = "      test";
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(15, 99);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(169, 23);
            this.Button_Start.TabIndex = 9;
            this.Button_Start.Text = "Старт";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // TextBox_IncomigMessages
            // 
            this.TextBox_IncomigMessages.Location = new System.Drawing.Point(15, 166);
            this.TextBox_IncomigMessages.Multiline = true;
            this.TextBox_IncomigMessages.Name = "TextBox_IncomigMessages";
            this.TextBox_IncomigMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_IncomigMessages.Size = new System.Drawing.Size(403, 142);
            this.TextBox_IncomigMessages.TabIndex = 10;
            // 
            // Button_Stop
            // 
            this.Button_Stop.Location = new System.Drawing.Point(236, 99);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(182, 23);
            this.Button_Stop.TabIndex = 11;
            this.Button_Stop.Text = "Стоп";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Timer_Sending_a_message
            // 
            this.Timer_Sending_a_message.Enabled = true;
            this.Timer_Sending_a_message.Interval = 1000;
            this.Timer_Sending_a_message.Tick += new System.EventHandler(this.Timer_Sending_a_message_Tick);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(304, 137);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(114, 23);
            this.Button_Clear.TabIndex = 12;
            this.Button_Clear.Text = "Очистить";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Main_FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 333);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.TextBox_IncomigMessages);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.Label_message);
            this.Controls.Add(this.SET_Port_Server);
            this.Controls.Add(this.SET_IP_Adress_Server);
            this.Controls.Add(this.Label_Port);
            this.Controls.Add(this.Label_IP_Adress);
            this.Controls.Add(this.Label_description);
            this.Name = "Main_FormClient";
            this.Text = "Client";
            this.SizeChanged += new System.EventHandler(this.FormClient_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_description;
        private System.Windows.Forms.Label Label_IP_Adress;
        private System.Windows.Forms.Label Label_Port;
        private System.Windows.Forms.TextBox SET_IP_Adress_Server;
        private System.Windows.Forms.TextBox SET_Port_Server;
        private System.Windows.Forms.Label Label_message;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.TextBox TextBox_IncomigMessages;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Timer Timer_Sending_a_message;
        private System.Windows.Forms.Button Button_Clear;
        public System.Windows.Forms.Button Button_Start;
    }
}

