using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnComprarClicked (object sender, EventArgs e)
	{
		float a = float.Parse(this.entry1.Text);
		float b= float.Parse(this.entry2.Text);
		float c= float.Parse(this.entry3.Text);

		float sub=a+b+c;

		this.entry4.Text=sub.ToString(); 

		double i=sub*.16;
		this.entry5.Text=i.ToString(); 

		double t=sub+i;

		this.entry6.Text=t.ToString();


	     
		 
	}

	protected void OnLimpiarClicked (object sender, EventArgs e)
	{
		this.entry1.Text="";
			this.entry1.Text="";
		this.entry2.Text="";
		this.entry3.Text="";
		this.entry4.Text="";
		this.entry5.Text="";
		this.entry6.Text="";
	}
}