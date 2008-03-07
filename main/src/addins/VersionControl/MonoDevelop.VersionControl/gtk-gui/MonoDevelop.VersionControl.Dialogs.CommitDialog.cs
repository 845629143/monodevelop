// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.VersionControl.Dialogs {
    
    
    internal partial class CommitDialog {
        
        private Gtk.VBox mainBox;
        
        private Gtk.Label label1;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TreeView fileList;
        
        private Gtk.VBox vboxExtensions;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TextView textview;
        
        private Gtk.Label label2;
        
        private Gtk.Button button29;
        
        private Gtk.Button button31;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.VersionControl.Dialogs.CommitDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.VersionControl.Dialogs.CommitDialog";
            this.Title = Mono.Unix.Catalog.GetString("Commit Files");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child MonoDevelop.VersionControl.Dialogs.CommitDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.mainBox = new Gtk.VBox();
            this.mainBox.Name = "mainBox";
            this.mainBox.Spacing = 6;
            this.mainBox.BorderWidth = ((uint)(6));
            // Container child mainBox.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Select the files to commit:");
            this.mainBox.Add(this.label1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.mainBox[this.label1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child mainBox.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.fileList = new Gtk.TreeView();
            this.fileList.CanFocus = true;
            this.fileList.Name = "fileList";
            this.fileList.HeadersClickable = true;
            this.scrolledwindow1.Add(this.fileList);
            this.mainBox.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.mainBox[this.scrolledwindow1]));
            w4.Position = 1;
            // Container child mainBox.Gtk.Box+BoxChild
            this.vboxExtensions = new Gtk.VBox();
            this.vboxExtensions.Name = "vboxExtensions";
            this.mainBox.Add(this.vboxExtensions);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.mainBox[this.vboxExtensions]));
            w5.PackType = ((Gtk.PackType)(1));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child mainBox.Gtk.Box+BoxChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.textview = new Gtk.TextView();
            this.textview.CanFocus = true;
            this.textview.Name = "textview";
            this.scrolledwindow2.Add(this.textview);
            this.mainBox.Add(this.scrolledwindow2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.mainBox[this.scrolledwindow2]));
            w7.PackType = ((Gtk.PackType)(1));
            w7.Position = 3;
            w7.Expand = false;
            w7.Fill = false;
            // Container child mainBox.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Commit message:");
            this.mainBox.Add(this.label2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.mainBox[this.label2]));
            w8.PackType = ((Gtk.PackType)(1));
            w8.Position = 4;
            w8.Expand = false;
            w8.Fill = false;
            w1.Add(this.mainBox);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.mainBox]));
            w9.Position = 0;
            // Internal child MonoDevelop.VersionControl.Dialogs.CommitDialog.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Events = ((Gdk.EventMask)(256));
            w10.Name = "VersionControlAddIn.CommitDialog_ActionArea";
            w10.Spacing = 6;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child VersionControlAddIn.CommitDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button29 = new Gtk.Button();
            this.button29.CanDefault = true;
            this.button29.CanFocus = true;
            this.button29.Name = "button29";
            this.button29.UseStock = true;
            this.button29.UseUnderline = true;
            this.button29.Label = "gtk-cancel";
            this.AddActionWidget(this.button29, -6);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.button29]));
            w11.Expand = false;
            w11.Fill = false;
            // Container child VersionControlAddIn.CommitDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button31 = new Gtk.Button();
            this.button31.CanDefault = true;
            this.button31.CanFocus = true;
            this.button31.Name = "button31";
            this.button31.UseUnderline = true;
            // Container child button31.Gtk.Container+ContainerChild
            Gtk.Alignment w12 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment1.Gtk.Container+ContainerChild
            Gtk.HBox w13 = new Gtk.HBox();
            w13.Spacing = 2;
            // Container child GtkHBox1.Gtk.Container+ContainerChild
            Gtk.Image w14 = new Gtk.Image();
            w14.Pixbuf = Stetic.IconLoader.LoadIcon(this, "vc-commit", Gtk.IconSize.Menu, 16);
            w13.Add(w14);
            // Container child GtkHBox1.Gtk.Container+ContainerChild
            Gtk.Label w16 = new Gtk.Label();
            w16.LabelProp = Mono.Unix.Catalog.GetString("Commit");
            w16.UseUnderline = true;
            w13.Add(w16);
            w12.Add(w13);
            this.button31.Add(w12);
            this.AddActionWidget(this.button31, -5);
            Gtk.ButtonBox.ButtonBoxChild w20 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.button31]));
            w20.Position = 1;
            w20.Expand = false;
            w20.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 628;
            this.DefaultHeight = 481;
            this.Show();
        }
    }
}
