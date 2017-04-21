using System;
using System.Linq;

namespace PatternsConsole.Structural.Flyweight
{
    public class FlyweightRunner : PatternRunnerBase
    {
        public override void Run()
        {
            Console.WriteLine("Creating document.");

            var doc = new Document();
            var row1 = (Row)doc.Add(new Row());
            row1.Add(GlyphFactory.Instance.GetGlyphs("h"));
            row1.Add(GlyphFactory.Instance.GetGlyphs("e"));
            row1.Add(GlyphFactory.Instance.GetGlyphs("l"));
            row1.Add(GlyphFactory.Instance.GetGlyphs("CC")); // case changed to upper
            row1.Add(GlyphFactory.Instance.GetGlyphs("l"));
            row1.Add(GlyphFactory.Instance.GetGlyphs("o"));

            var row2 = (Row)doc.Add(new Row());
            row2.Add(GlyphFactory.Instance.GetGlyphs("w"));
            row2.Add(GlyphFactory.Instance.GetGlyphs("o"));
            row2.Add(GlyphFactory.Instance.GetGlyphs("r"));
            row2.Add(GlyphFactory.Instance.GetGlyphs("CC")); // case changed to lower
            row2.Add(GlyphFactory.Instance.GetGlyphs("l"));
            row2.Add(GlyphFactory.Instance.GetGlyphs("d"));

            var row3 = (Row)doc.Add(new Row());
            row3.Add(GlyphFactory.Instance.GetCharacterGlyphs("Adding a string to a row."));

            Console.WriteLine("\nDocument:");
            doc.Draw(new GlyphContext());

            Console.WriteLine("\nDocument (FV):");
            doc.Draw(new GlyphContext {ForceVisual = true});

            Console.WriteLine($"\nDoc length: {doc.Length}");
            Console.WriteLine($"Factory glyphs count: {GlyphFactory.Instance.GlyphsCount}");
            Console.WriteLine("Factory glyph:");
            GlyphFactory.Instance.Glyphs.ToList()
                .ForEach(x => 
                {
                    x.Draw(new GlyphContext {ForceVisual = true});
                    Console.Write("\n");
                });
        }

        public override PatternCategory Category => PatternCategory.Structural;
        public override string Name => "Flyweight";
        public override string Description => BreakLine("Use sharein to support large numbers of fine-grained objects efficiently.");
        public override string PageRef => "195";

        public override string ApplicabilityLeadin => BreakLine("The Flyweight pattern's effectiveness depends heavily on how and where it's used. Apply the Flyweight pattern when _all_ of the following are true:",newlineStart:"",lineLength:80);

        protected override string[] ApplicabilityLines => new[]
        {
            BreakLine("An application uses a large number of objects."),
            BreakLine("Storage costs are high because of the sheer quantity of objects."),
            BreakLine("Most object state can be made extrinsic."),
            BreakLine("Many groups of objects may be replaced by relatively few shared objects once extrinsic state is removed."),
            BreakLine("The application doesn't depend on object identity. Since flyweight objects may be shared, identity test will return true for conceptually distinct objects.")
        };

        
        protected override string[] ConsequencesLines => new[]
        {
            BreakLine("May increase run-time costs associated with transfering, finding and/or computing extrinsic state."),
            BreakLine("Run-time costs are offset by space savings, increasing as more flyweights are shared."),
            BreakLine("The flyweight patterin is often combined with the Composite pattern to represent a hierarchical structure.")
        };
    }
}