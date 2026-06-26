using SparkyRailwayIECC.Modules.RailAssets.Domain.Assets.TrackCircuits;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SparkyRailwayIECC.Modules.RailAssets.Domain.Assets.Signals
{
    internal class Signal
    {
        public string Id { get; }
        public Aspect Aspect { get; }
        public Route? CurrentRoute { get; }
        public List<TrackCircuit> ProtectedTrackCircuits { get; } = [];
        public InterlockingState State {  get; }

        public Signal(string id, Aspect aspect, Route? currentRoute, List<TrackCircuit> protectedTrackCircuits, InterlockingState state)
        {
            Id = id;
            Aspect = aspect;
            CurrentRoute = currentRoute;
            ProtectedTrackCircuits = protectedTrackCircuits;
            State = state;
        }

        public void Clear() 
        { 
        }
        public void SetAspect(Aspect aspect) 
        { 
        }
    }
}
