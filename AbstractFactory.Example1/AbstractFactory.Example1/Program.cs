using AbstractFactory.Example1.Factories;
using AbstractFactory.Example1;

IThemeFactory themeFactory = new WinFactory();

IButton button = themeFactory.CreateButton();
button.Render();

IDropDown dropdown =themeFactory.CreateDropDrown();
dropdown.Render();

ITextBox textBox = themeFactory.CreateTextBox();
textBox.Render();