using oop4._2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oop4._2
{
    public partial class Form1 : Form
    {
        Model model;//объект класса Model
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observer += new EventHandler(UpdateFromModel);//обновление модели
            Application.ApplicationExit += Application_AppExit;
            UpdateFromModel(default, default);
        }

        private void Application_AppExit(object sender, EventArgs e)
        {
            model.Save();
        }//сохранение значений прри выходе

        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBoxA.Text = model.getA().ToString();
            textBoxB.Text = model.getB().ToString();
            textBoxC.Text = model.getC().ToString();
            numericUpDownA.Value = model.getA();
            numericUpDownB.Value = model.getB();
            numericUpDownC.Value = model.getC();
            trackBarA.Value = model.getA(); 
            trackBarB.Value = model.getB();
            trackBarC.Value = model.getC();
        }


        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            model.SetA(Int32.Parse(textBoxA.Text));
        }//установка значения в textBoxA
        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            model.SetB(Int32.Parse(textBoxB.Text));
        }//установка значения в textBoxB

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            model.SetC(Int32.Parse(textBoxC.Text));
        }//установка значения в textBoxC


        private void trackBarA_ValueChanged(object sender, EventArgs e)
        {
            model.SetA((Int32)trackBarA.Value);
        }//добавление значения в trackBarA

        private void trackBarB_ValueChanged(object sender, EventArgs e)
        {
            model.SetB((Int32)trackBarB.Value);
        }//добавление значения в trackBarB

        private void trackBarC_ValueChanged(object sender, EventArgs e)
        {
            model.SetC((Int32)trackBarC.Value);
        }//добавление значения в trackBarC


        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        { model.SetA((Int32)numericUpDownA.Value); }//добавление значения в numericUpDownA

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        { model.SetB((Int32)numericUpDownB.Value); }//добавление значения в numericUpDownB


        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        { model.SetC((Int32)numericUpDownC.Value); }//добавление значения в numericUpDownC


        /*private void labelA_Click(object sender, EventArgs e)
        {

        }*/

        

        
    }
    public class Model//класс модели
    {
        private int A, B, C;//передаваемые значения
        public readonly int max = 100;
        public readonly int min = 0;
        public Model()
        {
            A = Settings.Default.valueA;//для сохранения значений при закрытии приложения
            B = Settings.Default.valueB;
            C = Settings.Default.valueC;
           
        }
        public EventHandler observer;//объект класса EventHandler для обновления модели 
        public int getA() { return A; }//получение значения A
        public int getB() { return B; }//получения значения B
        public int getC() { return C; }//получения знчаения C

        public void SetA(int v)//установка значения в A
        {
            if (v > C)
            {
                observer.Invoke(this, null);
                return;
            }
            if (v > B && v <= C)
                B = v;
            A = v;
            observer.Invoke(this, null);//отправка обновления
        }
        public void SetB(int v)//установка значения в B
        {
            if (v > C || v < A)
            {
                observer.Invoke(this, null);
                return;
            }
            B = v;
            observer.Invoke(this, null);
        }
        public void SetC(int v)//установка значения в C
        {
            if (v< A)
            {
                observer.Invoke(this, null);
                return;
            }
            if (v < B)
                B = v;
            C = v;
            observer.Invoke(this, null);
        }
        public void Save()//метод для сохранения значений
        {
            Settings.Default.valueA = A;
            Settings.Default.valueB = B;
            Settings.Default.valueC = C;
            Settings.Default.Save();
        }

    }

}
