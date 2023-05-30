using Fasad.WashingMachine.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasad.WashingMachine
{
     class WashingMachine
    {
        private Engine _engine;
        private Thermo _thermo;
        private waterManagingSubsystem _water;
        private Dryer _dryer;

        public WashingMachine(Engine engine, Thermo thermo, waterManagingSubsystem water, Dryer dryer)
        {
            _engine = engine;
            _thermo = thermo;
            _water = water;
            _dryer = dryer;
        }

        public WashingMachine(Dryer dryer, Engine engine, Thermo thermo, waterManagingSubsystem water)
        {
            this._dryer = dryer;
            this._engine = engine;
            this._thermo = thermo;
            this._water = water;
        }

        public void WashCotton()
        {
            _water.FillWater(10);
            _thermo.WarmUp(70);
            _engine.Rotate();
            _engine.Stop();
            _water.EmptyWater();
            _dryer.Dry(10, 1000);
            _water.FillWater(15);
            _thermo.WarmUp(50);
            _engine.Rotate();
            _engine.Rotate();
            _engine.Stop();
            _water.EmptyWater();
            _dryer.Dry(60, 100);
        }

        public void WashWools()
        {
            _water.FillWater(7);
            _thermo.WarmUp(30);
            _engine.Rotate();
            _engine.Stop();
            _water.EmptyWater();
            _dryer.Dry(20, 500);

            _water.FillWater(10);
            _thermo.WarmUp(20);
            _engine.Rotate();
            _engine.Stop();
            _water.EmptyWater();
            _dryer.Dry(60, 700);
        }

        public int GetTemperature()
        {
            return _thermo.GetTemperature();
        }

    }
}
