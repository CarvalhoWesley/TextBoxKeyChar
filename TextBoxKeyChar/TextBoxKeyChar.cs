using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxKeyChar
{
    public partial class TextBoxKeyChar : TextBox
    {
        public TextBoxKeyChar()
        {
            InitializeComponent();
        }

        private int _keyValue;
        public int KeyValue
        {
            get
            {
                return _keyValue;
            }
            set
            {
                _keyValue = value;
                FillTextBox();
            }
        }
        private void FillTextBox()
        {
            switch (_keyValue)
            {
                case 27:
                    this.Text = "Esc";
                    break;
                case 112:
                    this.Text = "F1";
                    break;
                case 113:
                    this.Text = "F2";
                    break;
                case 114:
                    this.Text = "F3";
                    break;
                case 115:
                    this.Text = "F4";
                    break;
                case 116:
                    this.Text = "F5";
                    break;
                case 117:
                    this.Text = "F6";
                    break;
                case 118:
                    this.Text = "F7";
                    break;
                case 119:
                    this.Text = "F8";
                    break;
                case 120:
                    this.Text = "F9";
                    break;
                case 121:
                    this.Text = "F10";
                    break;
                case 122:
                    this.Text = "F11";
                    break;
                case 123:
                    this.Text = "F12";
                    break;
                case 145:
                    this.Text = "ScrollLock";
                    break;
                case 19:
                    this.Text = "PauseBreak";
                    break;
                case 192:
                    MessageBox.Show("Caracter não aceito. Escolha outro");
                    this.Focus();
                    break;
                case 48:
                    this.Text = "Alfa 0";
                    break;
                case 49:
                    this.Text = "Alfa 1";
                    break;
                case 50:
                    this.Text = "Alfa 2";
                    break;
                case 51:
                    this.Text = "Alfa 3";
                    break;
                case 52:
                    this.Text = "Alfa 4";
                    break;
                case 53:
                    this.Text = "Alfa 5";
                    break;
                case 54:
                    this.Text = "Alfa 6";
                    break;
                case 55:
                    this.Text = "Alfa 7";
                    break;
                case 56:
                    this.Text = "Alfa 8";
                    break;
                case 57:
                    this.Text = "Alfa 9";
                    break;
                case 8:
                    this.Text = "Back";
                    break;
                case 81:
                    this.Text = "q";
                    break;
                case 87:
                    this.Text = "w";
                    break;
                case 69:
                    this.Text = "e";
                    break;
                case 82:
                    this.Text = "r";
                    break;
                case 84:
                    this.Text = "t";
                    break;
                case 89:
                    this.Text = "t";
                    break;
                case 85:
                    this.Text = "u";
                    break;
                case 73:
                    this.Text = "i";
                    break;
                case 79:
                    this.Text = "o";
                    break;
                case 80:
                    this.Text = "p";
                    break;
                case 219:
                    MessageBox.Show("Caracter não aceito. Escolha outro.");
                    this.Focus();
                    break;
                case 221:
                    MessageBox.Show("Caracter não aceito. Escolha outro.");
                    this.Focus();
                    break;
                case 13:
                    this.Text = "Enter";
                    break;
                case 20:
                    this.Text = "CapsLock";
                    break;
                case 65:
                    this.Text = "a";
                    break;
                case 83:
                    this.Text = "s";
                    break;
                case 68:
                    this.Text = "d";
                    break;
                case 70:
                    this.Text = "f";
                    break;
                case 71:
                    this.Text = "g";
                    break;
                case 72:
                    this.Text = "h";
                    break;
                case 74:
                    this.Text = "j";
                    break;
                case 75:
                    this.Text = "k";
                    break;
                case 76:
                    this.Text = "l";
                    break;
                case 186:
                    this.Text = "ç";
                    break;
                case 222:
                    MessageBox.Show("Caracter não aceito. Escolha outro.");
                    this.Focus();
                    break;
                case 220:
                    MessageBox.Show("Caracter não aceito. Escolha outro.");
                    this.Focus();
                    break;
                case 16:
                    this.Text = "Shift";
                    break;
                case 226:
                    this.Text = "|";
                    break;
                case 90:
                    this.Text = "z";
                    break;
                case 88:
                    this.Text = "x";
                    break;
                case 67:
                    this.Text = "c";
                    break;
                case 86:
                    this.Text = "v";
                    break;
                case 66:
                    this.Text = "b";
                    break;
                case 78:
                    this.Text = "n";
                    break;
                case 77:
                    this.Text = "m";
                    break;
                case 188:
                    this.Text = "<";
                    break;
                case 190:
                    this.Text = ">";
                    break;
                case 191:
                    this.Text = ":";
                    break;
                case 193:
                    this.Text = "?";
                    break;
                case 17:
                    this.Text = "Ctrl";
                    break;
                case 91:
                    MessageBox.Show("Caracter não aceito. Escolha outro.");
                    this.Focus();
                    break;
                case 18:
                    this.Text = "Alt";
                    break;
                case 32:
                    this.Text = "Espaço";
                    break;
                case 92:
                    MessageBox.Show("Caracter não aceito. Escolha outro.");
                    this.Focus();
                    break;
                case 93:
                    MessageBox.Show("Caracter não aceito. Escolha outro.");
                    this.Focus();
                    break;
                case 45:
                    this.Text = "Insert";
                    break;
                case 36:
                    this.Text = "Home";
                    break;
                case 33:
                    this.Text = "PageUp";
                    break;
                case 46:
                    this.Text = "Delete";
                    break;
                case 35:
                    this.Text = "End";
                    break;
                case 34:
                    this.Text = "PageDown";
                    break;
                case 38:
                    this.Text = "Up";
                    break;
                case 40:
                    this.Text = "Down";
                    break;
                case 37:
                    this.Text = "Left";
                    break;
                case 39:
                    this.Text = "right";
                    break;
                case 144:
                    MessageBox.Show("Caracter não aceito. Escolha outro.");
                    this.Focus();
                    break;
                case 111:
                    this.Text = "/";
                    break;
                case 106:
                    this.Text = "*";
                    break;
                case 109:
                    this.Text = "-";
                    break;
                case 107:
                    this.Text = "+";
                    break;
                case 194:
                    this.Text = ".";
                    break;
                case 110:
                    this.Text = ",";
                    break;
                case 96:
                    this.Text = "NumPad 0";
                    break;
                case 97:
                    this.Text = "NumPad 1";
                    break;
                case 98:
                    this.Text = "NumPad 2";
                    break;
                case 99:
                    this.Text = "NumPad 3";
                    break;
                case 100:
                    this.Text = "NumPad 4";
                    break;
                case 101:
                    this.Text = "NumPad 5";
                    break;
                case 102:
                    this.Text = "NumPad 6";
                    break;
                case 103:
                    this.Text = "NumPad 7";
                    break;
                case 104:
                    this.Text = "NumPad 8";
                    break;
                case 105:
                    this.Text = "NumPad 9";
                    break;
            }
        }
        protected virtual void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyValue = (int)e.KeyValue;
        }
    }
}
