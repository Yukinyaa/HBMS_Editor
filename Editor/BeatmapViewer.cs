using Editor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class BeatmapViewer : Panel
{
    public BeatmapViewer() : base()
    {
        //this.key
        this.DoubleBuffered = true;
    }

    public new bool DoubleBuffered
    {
        get
        {
            return base.DoubleBuffered;
        }
        set
        {
            base.DoubleBuffered = value;
        }
    }//*/
    public void DrawGuideLine(Graphics g, PlayingData pd)
    {
        Pen borderlinedrawer = new Pen(Color.White, 0.5f);

        for (int i = 0; i < pd.hsnapcnt; i++)//Horizontal guideline
        {
            int x = this.Width * (i + 1) / ((int)pd.hsnapcnt + 1);
            g.DrawLine(borderlinedrawer, x, 0, x, this.Height);
        }//Horizontal guideline

        int beat = ((int)(pd.now * 48 / pd.bsnapcnt)) * pd.bsnapcnt;
        double l = beat / 48d;
        while (beat < 0) beat += 48;
        for (; l < pd.now + pd.scale; l += 1d / 48d)
        {
            Pen linedrawer;
            beat %= 48;//detect beat
            if (beat % (48 / pd.bsnapcnt) != 0)
            {
                beat++;
                continue;
            }

            if (beat == 0 && ((l +12.1) % 4) < 0.4)//thick line every large beat(4 small beat)
                linedrawer = new Pen(Editor.BeatSnapColor.col[beat], 3);
            else
                linedrawer = new Pen(Editor.BeatSnapColor.col[beat], 1);
            int y = MusicMath.TimingToY(l,pd);
            g.DrawLine(linedrawer, 0, y, pd.width, y);
            beat++;
        }//vertical(beat)guideline
    }
    public void DrawLongNotes(Graphics g, PlayingData pd, List<Note> notes)
    {

    }

    public void DrawNotes(Graphics g, PlayingData pd, List<Note> notes)
    {
        foreach (Note n in notes)
        {
            if ((pd.now <= n.timing) && (n.timing <= pd.now + pd.scale))
                DrawNote(g, pd, n);
        }
    }

    public void DrawNote(Graphics g, PlayingData pd, Note n, object color = null, int dx = 0, int dy = 0)
    {
        Color c;
        if (color == null) switch (n.type)
            {//set color for default
                case NoteType.ShortNote:
                    c = Color.White;
                    break;
                case NoteType.SlideLongNote:
                    c = Color.GreenYellow;
                    break;
                default:
                    c = Color.Red;
                    break;
            }
        else c = (Color)color;

        g.DrawRectangle(new Pen(c, 2), MusicMath.RectFromNote(n, pd, dx, dy));
    }

    public void DrawImaginaryNote(Graphics g, PlayingData pd, Note DraggingNote, Note SelectedNote, bool dragging, Point draggingDelta)
    {
        //draw dragging note
        ///todo: draggingnote delta beat
        if (dragging)
            DrawNote(g, pd, DraggingNote, Color.Gray, draggingDelta.X, draggingDelta.Y);
        //draw selected note
        if (SelectedNote != null)
            g.DrawRectangle(new Pen(Color.Yellow, 1), MusicMath.RectFromNote(SelectedNote, pd));
    }
}