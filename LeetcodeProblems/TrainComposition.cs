using System;
using System.Collections.Generic;
namespace LeetcodeProblems {


    public class TrainComposition {

        private LinkedList<int> train = new LinkedList<int>();

        public void AttachWagonFromLeft(int wagonId) {

            train.AddFirst(wagonId);
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public void AttachWagonFromRight(int wagonId) {
            train.AddLast(wagonId);
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public int DetachWagonFromLeft() {
            int wagonId = train.First.Value;
            train.RemoveFirst();
            return wagonId;
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public int DetachWagonFromRight() {
            int wagonId = train.Last.Value;
            train.RemoveLast();
            return wagonId;
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public void MainMethod() {
            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);
            Console.WriteLine(tree.DetachWagonFromRight()); // 7 
            Console.WriteLine(tree.DetachWagonFromLeft()); // 13
        }
    }
}
