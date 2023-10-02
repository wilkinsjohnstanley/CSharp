private void DiscountButton_Click(object sender, EventArgs e)
{
  int agae;
  char rating;
  const int CHILD_AGE = 12;
  const int SENIOR_AGE = 65;
  age = Convert.ToInt32(textBox1.Text);
  rating = Convert.ToChar(textBox2.Text);
  outputLabel.Text = String.Format
    ("When age is {0} and rating is {1}", age, rating);
  if((age<=CHILD_AGE || age >=SENIOR_AGE) && rating == 'G')
    outputLabel.Text += "\nDiscount applies";
  else
    outputLabel.Text += "\nFull price";
}
