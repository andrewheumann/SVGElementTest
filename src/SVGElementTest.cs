using Elements;
using Elements.Geometry;
using System;
using System.Collections.Generic;
using System.IO;

namespace SVGElementTest
{
    public static class SVGElementTest
    {
        /// <summary>
        /// The SVGElementTest function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A SVGElementTestOutputs instance containing computed results and the model with any new elements.</returns>
        public static SVGElementTestOutputs Execute(Dictionary<string, Model> inputModels, SVGElementTestInputs input)
        {
            var outputs = new SVGElementTestOutputs();
            // var svgFile = input.SVGFile.LocalFilePath;
            // var fileName = Path.GetFileNameWithoutExtension(svgFile);
            // var svgContent = File.ReadAllText(svgFile);
            // var svgElement = new SVGGraphic(svgContent, Guid.NewGuid(), fileName);
            // outputs.Model.AddElement(svgElement);
            var rect = Polygon.Rectangle(input.Length, input.Width);
            var svg = new SVG();
            svg.AddGeometry(Polygon.Rectangle(10, 10), new SVG.Style
            {
                EnableFill = false,
                EnableStroke = false
            });
            svg.AddGeometry(rect, new SVG.Style
            {
                Fill = Colors.Red,
                Stroke = Colors.Blue,
                StrokeWidth = input.StrokeWidth
            });
            var svgElement2 = new SVGGraphic(svg.SvgString(), Guid.NewGuid(), "Rectangle");
            outputs.Model.AddElement(svgElement2);
            return outputs;
        }
    }
}