using System;
using System.Collections.Generic;

using Guru.DependencyInjection;
using Guru.DependencyInjection.Abstractions;

using RoutePlanning.Algorithm.TimeDependent;
using RoutePlanning.Algorithm.TimeDependent.Model;
using RoutePlanning.DataProvider.TimeDependent.Cache;

namespace RoutePlanning.DataProvider.TimeDependent
{
    [DI(typeof(IDataProvider), Lifetime = Lifetime.Singleton)]
    public class DefaultDataProvider : IDataProvider
    {
        private readonly IAirportCache _AirportCache;

        private readonly IFlightCache _FlightCache;

        private readonly IStationCache _StationCache;

        private readonly ITrainCache _TrainCache;

        public DefaultDataProvider(
            IAirportCache airportCache,
            IFlightCache flightCache,
            IStationCache stationCache,
            ITrainCache trainCache)
        {
            _AirportCache = airportCache;
            _FlightCache = flightCache;
            _StationCache = stationCache;
            _TrainCache = trainCache;
        }

        public IEnumerable<IEdge> GetOutgoingEdges(INode node, DateTime arrivalTimeOfNode)
        {
            throw new NotImplementedException();
        }
    }
}