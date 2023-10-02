private void button1_Click(oobject sender, EventArgs e)
{
  int num1;
  int num2;
  int sum;
  num1 = Convert.ToInt32(textBox1.Text);
  num2 = Convert.ToInt32(textBox2.Text);
  sum = num1+num2;
  label3.Text="Sum is "+sum;
}
