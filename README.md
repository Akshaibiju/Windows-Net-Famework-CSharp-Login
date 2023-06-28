# Windows Forms C# (.NET FRAMEWORK)

To give the value of a TextBox to a public class variable and provide access to it from Form1, you can follow these steps:

Create a public class: Create a new public class in your project to hold the shared data. This class will have a public variable to store the TextBox value.

```
public class SharedData
{
    public static string TextBoxValue { get; set; }
}
```
Open Form2 in Design View: Double-click on Form2 in the Solution Explorer to open it in the Design view.

Add a Button Control: From the Toolbox, drag and drop a Button control onto Form2.

Handle Button Click Event: Double-click on the button to generate a click event handler for it. This will take you to the code-behind file for Form2.

Inside the Button Click Event Handler: Assign the TextBox value to the public variable in the SharedData class.

```
private void button1_Click(object sender, EventArgs e)
{
    SharedData.TextBoxValue = textBox1.Text;
    this.Close(); // Close Form2
}
```

Open Form1 in Design View: Double-click on Form1 in the Solution Explorer to open it in the Design view.

Add a Button Control: From the Toolbox, drag and drop a Button control onto Form1.

Handle Button Click Event: Double-click on the button to generate a click event handler for it. This will take you to the code-behind file for Form1.

Inside the Button Click Event Handler: Access the TextBox value from the SharedData class.

```
private void button1_Click(object sender, EventArgs e)
{
    string textBoxValue = SharedData.TextBoxValue;
    MessageBox.Show(textBoxValue);
}
```
By storing the TextBox value in a public variable of the SharedData class, you can access it from both Form1 and Form2. Make sure to adjust the control names and property names according to your specific application.
