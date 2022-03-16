using System;
using System.Threading;

namespace FRC_PreScouting_AutoGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a team number");
            double.TryParse(Console.ReadLine(), out double teamNumber);
            Console.WriteLine("Please enter a year");
            double.TryParse(Console.ReadLine(), out double year);

            Generation generation = new Generation(teamNumber, year);

            generation.getTeamEvents();
        }
    }

    class Generation {
        private double _year;
        private double _team;
        public Generation(double year, double team){
            _year = year;
            _team = team;
        }
        /**
            Team        Event      Ranking      Win Percent         Awards
            2771        EK         1            0.00%               xxxx
            2767        EK         2            0.00%               xxxx
            3357        EK         3            0.00%               xxxx  
        **/

        // getTeamEvents(2771) -> getTeamsAtEvent(Miken2018) -> getTeamEventResults(2771, Miken2018),getTeamEventResults(3357, Miken2018)

        // Get all events for a team. Returns an array of event codes (string).
        // Once all teams are gotten, run getTeamEventResults on separate threads.
        public string[] getTeamEvents(){
            return new string[]{}; // Placeholder
        }

        
        // Get all teams at an event. Returns an array of teams and the event code (double, string).
        public double[] getTeamsAtEvent(string eventCode){
            return new double[0]; // Placeholder
        }

        // Get the match results, ranking, awards for a team at an event. Returns array of strings containing the results.
        public string[] getTeamEventResults(double team, string eventCode){
            return new string[]{}; // Placeholder
        }
    }

    class TBA {

    }
}
