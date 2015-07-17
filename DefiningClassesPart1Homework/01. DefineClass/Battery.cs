using System;

// • Define 3 separate classes (class  GSM  holding instances of the classes  Battery  and  Display ).

namespace DefineClasses
{
    public class Battery
    {
        //constants
        private const string DEFAULT_MODEL = "Unknown";
        private const int DEFAULT_HOURS_IDLE = 20;
        private const int DEFAULT_HOURS_TALK = 30;
        private const Type BATTERY_TYPE = Type.LiIon;

        //fields
        private string batteryModel;
        private int batteryHoursIdle;
        private int batteryHoursTalk;
        private Type batteryType;

        //constructor without parameters
        public Battery()
            : this(DEFAULT_MODEL, DEFAULT_HOURS_IDLE, DEFAULT_HOURS_TALK, BATTERY_TYPE)
        {
        }

        // constructor with one parameter - model
        public Battery(string batteryModel)
            : this(batteryModel, DEFAULT_HOURS_IDLE, DEFAULT_HOURS_TALK, BATTERY_TYPE)
        {
        }

        //full constructor with three parameters - model, hours idle and hours talk
        public Battery(string batteryModel, int batteryHoursIdle, int batteryHoursTalk, Type batteryType)
        {
            this.BatteryModel = batteryModel;
            this.BatteryHoursIdle = batteryHoursIdle;
            this.BatteryHoursTalk = batteryHoursTalk;
            this.BatteryType = batteryType;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The battery model cannot be null or empty");
                }
                this.batteryModel = value;
            }
        }
        public int BatteryHoursIdle
        {
            get
            {
                return this.batteryHoursIdle;
            }
            private set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Hours idle should be > 0 and  < 100");
                }
                this.batteryHoursIdle = value;
            }
        }
        public int BatteryHoursTalk
        {
            get
            {
                return this.batteryHoursTalk;
            }
            private set
            {
                if (value <= 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Hours talk shoule be > 0 and < 50");
                }
                this.batteryHoursTalk = value;
            }
        }

        public Type BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public enum Type
        {
            LiIon,
            NiMH,
            NiCd
        }
    }
}
