using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRAC2
{
    public partial class Nazarov : Form
    {
        // <summary>
        /// Класс Nazarov производит инициализацию компонентов
        /// </summary>
        public Nazarov()
        {
            InitializeComponent();
            txtX.Text = "" + 1.825 * Math.Pow(10, 2);
            txtY.Text = "18,225";
        }
        ///<summary>
        /// Метод Reshenie(),который выполняет решение примера 
        ///</summary>
        ///<param name="х">1 число</param>
        ///<param name="у">2 число</param>
        private void Reshenie(ref double x, ref double y)
        {
            double c = 0;
            double db = Math.Pow(x, 2);
            double db1 = Math.Pow(y, 3);
            double db2 = y * (1 - x);
            double db3 = Math.Abs(x) + y;
            double otvet = db + db1 - (db2 / db3);
            txtOtv.Text = c + "= " + otvet.ToString();
        }
        ///<summary>
        ///Метод btnStart_Click,которыйзапускаетметод Reshenie() 
        ///</summary>
        ///<param name="sender">Объект,который вызывает событие</param>
        ///<param name="e">Дает возможность передать значения обработчику</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            Reshenie(ref x, ref y);

        }
    }

}
