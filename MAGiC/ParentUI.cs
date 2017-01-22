using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGiC
{
    public class ParentUI
    {
        public Label lbl_empty = new Label { Text = "  ", Width = 10, Font = new Font("Arial", 11, FontStyle.Bold) };


        public INavigationListener navigationListener;

        public ParentUI(INavigationListener _navigationListener)
        {
            navigationListener = _navigationListener;
        }

        public ParentUI()
        {

        }


        public static GroupBox CreateGBox(String title, params Control[] arr)
        {
            GB gb = new GB { Text = title, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, Font = new Font("Arial", 11, FontStyle.Bold) };
            VFLP p = new VFLP();
            gb.Controls.Add(p);
            for (int i = 0; i < arr.Length; i += 2)
            {
                var c = CreateHPanel(arr[i], arr[i + 1]);
                p.Controls.Add(c);
            }
            return gb;
        }

        public class GB : GroupBox
        {
            public override Size GetPreferredSize(Size proposedSize)
            {
                var c = Controls[0];
                Size s = c.GetPreferredSize(proposedSize);
                var m = c.Margin;
                var p = this.Padding;
                s.Height += m.Vertical + p.Vertical;
                s.Width += m.Horizontal + p.Horizontal;
                s.Height += DisplayRectangle.Y;
                return s;
            }
        }

        public static Panel CreateHPanel(params Control[] arr)
        {
            return new HFLP(arr);
        }

        public class VFLP : FlowLayoutPanel
        {
            public VFLP()
            {
                FlowDirection = FlowDirection.TopDown;
                WrapContents = false;
                Dock = DockStyle.Fill;
                AutoSize = true;
                AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }
            public override Size GetPreferredSize(Size proposedSize)
            {
                Size s = Size.Empty;
                foreach (Control c in Controls)
                {
                    var ps = c.PreferredSize;
                    var m = c.Margin;
                    ps.Width += m.Horizontal;
                    ps.Height += m.Vertical;
                    s.Height += ps.Height;
                    if (ps.Width > s.Width)
                        s.Width = ps.Width;
                }
                Padding p = this.Padding;
                s.Width += p.Horizontal;
                s.Height += p.Vertical;
                return s;
            }
        }

        public class HFLP : FlowLayoutPanel
        {
            public HFLP(Control[] arr)
            {
                AutoSize = true;
                FlowDirection = FlowDirection.LeftToRight;
                WrapContents = false;
                foreach (Control c in arr)
                {
                    c.AutoSize = true;
                    c.Anchor = AnchorStyles.None;
                    Controls.Add(c);
                }

            }
            public override Size GetPreferredSize(Size proposedSize)
            {
                Size ps = Size.Empty;
                foreach (Control c in Controls)
                {
                    Size s = c.PreferredSize;
                    Padding m = c.Margin;
                    s.Width += m.Horizontal;
                    s.Height += m.Vertical;
                    ps.Width += s.Width;
                    if (s.Height > ps.Height)
                        ps.Height = s.Height;
                }

                return ps;
            }
        }

    }
}
