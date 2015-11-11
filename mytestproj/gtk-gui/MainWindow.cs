
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Label headerLabel;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.VBox vbox5;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Button fileButton;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	
	private global::Gtk.TextView textview3;
	
	private global::Gtk.VBox vbox6;
	
	private global::Gtk.Label lexemeLabel;
	
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.ScrolledWindow lexemeWindow;
	
	private global::Gtk.TreeView lexemeTree;
	
	private global::Gtk.VBox vbox7;
	
	private global::Gtk.Label symbolTableLabel;
	
	private global::Gtk.HBox hbox6;
	
	private global::Gtk.ScrolledWindow symbolTableWindow;
	
	private global::Gtk.TreeView symbolTableTree;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Button executeButton;
	
	private global::Gtk.Label consoleLabel;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView consoleField;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(16));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.headerLabel = new global::Gtk.Label ();
		this.headerLabel.Name = "headerLabel";
		this.headerLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("#bestProjectEver");
		this.vbox1.Add (this.headerLabel);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.headerLabel]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Homogeneous = true;
		this.hbox4.Spacing = 15;
		this.hbox4.BorderWidth = ((uint)(7));
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Homogeneous = true;
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.hbox2.Add (this.label1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.fileButton = new global::Gtk.Button ();
		this.fileButton.CanFocus = true;
		this.fileButton.Name = "fileButton";
		this.fileButton.UseUnderline = true;
		this.fileButton.Label = global::Mono.Unix.Catalog.GetString ("Open file...");
		this.hbox2.Add (this.fileButton);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fileButton]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox5.Add (this.hbox2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox2]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.textview3 = new global::Gtk.TextView ();
		this.textview3.WidthRequest = 250;
		this.textview3.CanFocus = true;
		this.textview3.Name = "textview3";
		this.GtkScrolledWindow1.Add (this.textview3);
		this.vbox5.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow1]));
		w6.Position = 1;
		this.hbox4.Add (this.vbox5);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox5]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.lexemeLabel = new global::Gtk.Label ();
		this.lexemeLabel.Name = "lexemeLabel";
		this.lexemeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Lexemes");
		this.vbox6.Add (this.lexemeLabel);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.lexemeLabel]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Homogeneous = true;
		// Container child hbox5.Gtk.Box+BoxChild
		this.lexemeWindow = new global::Gtk.ScrolledWindow ();
		this.lexemeWindow.CanFocus = true;
		this.lexemeWindow.Name = "lexemeWindow";
		this.lexemeWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child lexemeWindow.Gtk.Container+ContainerChild
		this.lexemeTree = new global::Gtk.TreeView ();
		this.lexemeTree.WidthRequest = 250;
		this.lexemeTree.CanFocus = true;
		this.lexemeTree.Name = "lexemeTree";
		this.lexemeWindow.Add (this.lexemeTree);
		this.hbox5.Add (this.lexemeWindow);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.lexemeWindow]));
		w10.Position = 0;
		this.vbox6.Add (this.hbox5);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox5]));
		w11.Position = 1;
		this.hbox4.Add (this.vbox6);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox6]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.symbolTableLabel = new global::Gtk.Label ();
		this.symbolTableLabel.Name = "symbolTableLabel";
		this.symbolTableLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Symbol Table");
		this.vbox7.Add (this.symbolTableLabel);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.symbolTableLabel]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Homogeneous = true;
		// Container child hbox6.Gtk.Box+BoxChild
		this.symbolTableWindow = new global::Gtk.ScrolledWindow ();
		this.symbolTableWindow.CanFocus = true;
		this.symbolTableWindow.Name = "symbolTableWindow";
		this.symbolTableWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child symbolTableWindow.Gtk.Container+ContainerChild
		this.symbolTableTree = new global::Gtk.TreeView ();
		this.symbolTableTree.WidthRequest = 250;
		this.symbolTableTree.CanFocus = true;
		this.symbolTableTree.Name = "symbolTableTree";
		this.symbolTableWindow.Add (this.symbolTableTree);
		this.hbox6.Add (this.symbolTableWindow);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.symbolTableWindow]));
		w15.Position = 0;
		this.vbox7.Add (this.hbox6);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox6]));
		w16.Position = 1;
		this.hbox4.Add (this.vbox7);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox7]));
		w17.Position = 2;
		w17.Expand = false;
		w17.Fill = false;
		this.vbox1.Add (this.hbox4);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
		w18.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.executeButton = new global::Gtk.Button ();
		this.executeButton.CanFocus = true;
		this.executeButton.Name = "executeButton";
		this.executeButton.UseUnderline = true;
		this.executeButton.Label = global::Mono.Unix.Catalog.GetString ("EXECUTE");
		this.vbox2.Add (this.executeButton);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.executeButton]));
		w19.Position = 0;
		w19.Expand = false;
		w19.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.consoleLabel = new global::Gtk.Label ();
		this.consoleLabel.Name = "consoleLabel";
		this.consoleLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Console");
		this.vbox2.Add (this.consoleLabel);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.consoleLabel]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.consoleField = new global::Gtk.TextView ();
		this.consoleField.CanFocus = true;
		this.consoleField.Name = "consoleField";
		this.GtkScrolledWindow.Add (this.consoleField);
		this.vbox2.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
		w22.Position = 2;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w23.Position = 2;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 883;
		this.DefaultHeight = 346;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.fileButton.Clicked += new global::System.EventHandler (this.OnFileButtonClicked);
		this.executeButton.Clicked += new global::System.EventHandler (this.OnExecuteButtonClicked);
	}
}