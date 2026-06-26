using System;
using System.Collections.Generic;
using System.Text;

namespace SparkyRailwayIECC.Modules.RailAssets.Domain.Assets.TrackCircuits
{
    internal sealed class TrackCircuitViewModel
    {
        internal TrackCircuit Model { get;  }

        public double X1 { get; init; }
        public double Y1 { get; init; }
        public double X2 { get; init; }
        public double Y2 { get; init; }

        public TrackCircuitViewModel(TrackCircuit model)
        {
            Model = model;
        }
    }
}
