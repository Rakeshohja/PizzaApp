﻿namespace PizzaApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("ContactUsPage", typeof(PizzaApp.Pages.ContactUsPage));
    }
}
