using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Abre nova janela do Chrome, navega até o site do Google, localiza a barra de pesquisa e faz a busca com o tema "hello, world"
        var options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        var driver = new ChromeDriver(options);
        driver.Navigate().GoToUrl("https://www.google.com");
        var input = driver.FindElement(By.Name("q"));
        input.SendKeys("hello, world");
        input.Submit();
        Console.Read();
    }
}
