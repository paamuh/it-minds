using System;
using System.Collections.Generic;

namespace WhatTheFind
{
    public static class Extensions
    {
        /// <summary>
        /// Find any node in an object graph that satisfy a given predicate and return it.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="root">The root node.</param>
        /// <param name="predicate">The given condition to satisfy.</param>
        /// <param name="getChildren">Child selector.</param>
        /// <returns>Node satisfying the condition, else null.</returns>
        public static T FindWhere<T>(this T root, Func<T, bool> predicate, Func<T, IEnumerable<T>> getChildren)
            where T : class
        {
            // YOUR SOLUTION GOES HERE



            //I dont know how to use these parameters.
            //this will be psudolikeCode to show my thinking on this problem.

            //check if root is the one were looking for
            if (predicate(root) == true)
            {
                return root;
            }

            //pointer to travers throug the graph.
            T CurrentNode = root;
            T lastNode = null;
            bool correctNodeFound = false;

            //Then check if currentNode have eny children.First check leftChild then rightchild. If currentNode got children, check them with predicate func.
            while (correctNodeFound != true)
            { 

                if (CurrentNode.getChildren.leftChild)
                {
                    lastNode = CurrentNode;
                    CurrentNode = CurrentNode.leftChild;
                    if (predicate(CurrentNode))
                    {
                        
                        correctNodeFound = true;
                        return CurrentNode;
                    }
                    else if (lastNode.getChildren.rightChild != null)
                    {
                        
                        CurrentNode = lastNode.getChildren.rightChild;
                        if (predicate(CurrentNode){
                            correctNodeFound = true;
                            return CurrentNode;
                        }

                    }
                    
                }
            }
           




            throw new NotImplementedException();
        }
    }
}
