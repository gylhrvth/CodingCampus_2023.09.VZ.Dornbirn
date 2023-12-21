using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Michael.Week08.FileSystem
{
    internal class Main
    {


        public static void Start()
        {
            /*
            DirectoryInfo dirInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            dirInfo = dirInfo.Parent.Parent.Parent;
            Exercises.PrintCurrentFolder(dirInfo.FullName);
            Console.WriteLine();
            string file1 = dirInfo.FullName + "\\testfile.txt";
            string file2 = dirInfo.FullName + "\\newfilepls.txt";
            Exercises.ReadFile(file1);
            Exercises.CopyFromToShout(file1, file2);
            //Exercises.WriteFile(file1);
            Exercises.ReadFile(file2);
            //Exercises.WriteFile(file2);
            */


           
            Console.ReadLine();

            Random rnd = new Random();

            Graph labyrinth = CreateLabyrinthGraph();
            bool[,] field = GetLabyrinthBoolean();



            Node startNode = labyrinth.Nodes[rnd.Next(labyrinth.Nodes.Count())];
            Node endNode = labyrinth.Nodes[rnd.Next(labyrinth.Nodes.Count())];
            List<Node> solution = Dijkstra(startNode, endNode, labyrinth.Nodes);


            PrintLabyrinth(field, solution, startNode, endNode);

            Console.Read();
            

        }



         

        public static void PrintLabyrinth(bool[,] field, List<Node> solution, Node startNode, Node endNode)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    bool foundSomething = false;
                    foreach (Node toDraw in solution)
                    {
                        if (row == toDraw.yCoord && col == toDraw.xCoord)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                            if (toDraw == endNode)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (toDraw == startNode)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            Console.Write("■ ");
                            Console.ResetColor();
                            foundSomething = true;
                            break;
                        }
                    }

                    if (!foundSomething)
                    {
                        string toPrint = "";
                        if (!field[row, col])
                        {
                            int result = BinaryMaskOrSomething(field, row, col);

                            switch (result)
                            {
                                case 0: toPrint = "O "; break;
                                case 1:
                                case 4:
                                case 5: toPrint = "║ "; break;
                                case 2:
                                case 8:
                                case 10: toPrint = "══"; break;
                                case 3: toPrint = "╚═"; break;
                                case 6: toPrint = "╔═"; break;
                                case 7: toPrint = "╠═"; break;
                                case 9: toPrint = "╝ "; break;
                                case 11: toPrint = "╩═"; break;
                                case 12: toPrint = "╗ "; break;
                                case 13: toPrint = "╣ "; break;
                                case 14: toPrint = "╦═"; break;
                                case 15: toPrint = "╬═"; break;
                            }
                        }
                        else
                        {
                            toPrint = "  ";
                        }
                        Console.Write(toPrint);
                    }

                }
                Console.WriteLine();
            }
        }


        public static int BinaryMaskOrSomething(bool[,] field, int row, int col)
        {
            int result = 0;
            try
            {
                if (field[row - 1, col] == false) result += 1;
            }
            catch { }

            try
            {
                if (field[row, col + 1] == false) result += 2;
            }
            catch { }

            try
            {
                if (field[row + 1, col] == false) result += 4;
            }
            catch { }

            try
            {
                if (field[row, col - 1] == false) result += 8;
            }
            catch { }

            return result;
        }


        public static List<Node> Dijkstra(Node start, Node end, List<Node> setting)
        {
            Dictionary<Node, Node> previousNeighbor = new Dictionary<Node, Node>();
            List<Node> unvisited = new List<Node>();

            foreach(Node node in setting)
            {
                unvisited.Add(node);
                previousNeighbor.Add(node, node);
            }

            start.SetDistance(0);
            unvisited.Remove(start);

            Node currentNode = start;

            while (currentNode != end)
            {
                foreach(Node neighbor in currentNode.Neighbors)
                {
                    int temp = currentNode.CurrentDistance + 1;

                    if (temp < neighbor.CurrentDistance)
                    {
                        previousNeighbor[neighbor] = currentNode;
                        neighbor.SetDistance(temp);
                    }
                }

                unvisited.Remove(currentNode);

                currentNode = unvisited.MinBy(nd => nd.CurrentDistance);
                //currentNode = GetSmallestNode(unvisited);
            }


            List<Node> solution = new List<Node>();

            Node justAdded = end;
            solution.Add(justAdded);

            while(justAdded != start)
            {
                solution.Add(previousNeighbor[justAdded]);
                justAdded = previousNeighbor[justAdded];
            }

            return solution;
        }


        public static Graph CreateLabyrinthGraph()
        {
            bool[,] lab = GetLabyrinthBoolean();

            Graph labyrinth = new Graph();

            for (int row = 0; row < lab.GetLength(0); row++)
            {
                for (int col = 0; col < lab.GetLength(1); col++)
                {
                    if (lab[row, col])
                    {
                        labyrinth.AddNode(new Node(row, col));
                    }
                }
            }

            foreach (Node node in labyrinth.Nodes)
            {
                foreach (Node potentialNeighbor in labyrinth.Nodes)
                {
                    if ((Math.Abs(node.xCoord - potentialNeighbor.xCoord) == 1 && Math.Abs(node.yCoord - potentialNeighbor.yCoord) == 0) ||
                        (Math.Abs(node.xCoord - potentialNeighbor.xCoord) == 0 && Math.Abs(node.yCoord - potentialNeighbor.yCoord) == 1))
                    {
                        node.AddNeighbor(potentialNeighbor);
                    }
                }
            }

            return labyrinth;
        }


        public static bool[,] GetLabyrinthBoolean()
        { 
            string returnValue = "  ...........  .......  .   ......  ...........  \r\n %%%#%#%%%%%%#.%%%%%%%.%%%.%%%%%%%.%%#%%%%%%%%%% \r\n.%..........:%.%.....%.%:%.%.....%.%:..........%.\r\n.%.%%%%%%%%%%#.%.%%%.%.%:#.%.%%%.%.%%%%%%%%%%%.%.\r\n.%.%::.:.::::.:%:%:%:%:%:%:%:%:%.%:.:.:::.::.#.%.\r\n.%.%%%%%%%%%%%%%.%.%.%%%.%%%.%.#.%%%%%%%%%%%.#.%.\r\n.% .:.::.::::::.:%.%..:...:..@.%:.::.::::::%:#.%.\r\n.%.%%%%%%%%%%%%%%%.%.%%%%%%%.%.#%%%%%%%%%%%% #.%.\r\n.%.%:..............@:%.....%:%.......... ....%.%.\r\n.%.%#%%%.%%%%%%%%%%%.%.%%%.#.%%%%%%%%%%%.#%%%%.%.\r\n.%..:.:%:@:.:::::::.:%.%:%.%:.:::::::.:%.@:.:..%.\r\n.%%#%%.%.%.%%%#%%#%%%#.%:#.#%%%#%#%%%%.%:%.#%%%% \r\n ...:%:%:%:%....... ...%:%... .......%:%.%:%:..  \r\n.%%%%#.%.%:%.%%%%%#.%%%%.%%#%.%%%#%%.%:%:%.#%%%% \r\n.%..:.:%:%:%.%..::@.%:.. .::%.%:..:%.%.%.%:.:..%.\r\n.%.%%%%%.%:%.#.%%%#.%%%%.%%%% %%%%.%.%:%.%%%%% %.\r\n.%.%..:.:@:%.#.%.....::%:%::.....%:%.%.@:.:..%.%.\r\n.%.# %#%%%.%.#.%.%%%%%%%.#%%%%%%.%:%.%:%%%%%.#.%.\r\n.%.#.@:....%.#.%:@...... ......%.%:%.%....:%.#.%.\r\n.%.#.%%%%%%#.#.%.%.%%%%%.%%%%%.%.#:%.#.%%%%%.#.#.\r\n.%.%.::..::::%.%-@:@..:%:@:.:@-%.%:%:%:@:.:..%.%.\r\n.%.#%%%%.%%#%#.#%#.%.%%%.#%%.%%#.%.%%#.%.%%%%#.%.\r\n.%....:%:@:... ...:%:%.....%.....%....:@.@:....%.\r\n %%%%#.%.%%#%#.%%%%%.%.%@%.%:%%%%%.%%%%%.%.#%%%% \r\n .::-%.%..:::%.%:::..%.@@@.%:@:::..@:::. %:%-:.. \r\n %%%%#.%.%%%%#.%%%%%:%.%@%.%.%%%%%.%%%%%.%.#%%@%.\r\n.%....:%.@:::. ...:@.%..%..%..:..%..:..@.@:.:..%.\r\n.%.%%%%#.%%#%%.%%%.%.%%.%.%%.%%%.%.%%%.%.#%%%%.%.\r\n.%.%.... ....%.%:%:@..%.%.%..@:%.%:%:%:%:....#.%.\r\n.%.#.%%#%%%#.#.%.%.%%.%.%.%%%%.%.%:%.#.%%%%%.#.%.\r\n.#.#.@:::..%.#.%:%.:%:#.%.....:%.%:%.%..:::@:#.%.\r\n.%.#.%%%%%.%.#.%.%%%#.%.#%%%.%%#.%:%.%.%%%%%.#.%.\r\n.%.%.....@.%.#.%......% ..:@.@:..%:%.%:%:....%.%.\r\n.% #%%%%.%:%.#.%%%%%%.%.%%%#.%%%%#.%.%.%.%%%%% %.\r\n.%:.:.:%:%:%.%:.::::%:%.%:....:.:::%.%:%:%:...:%.\r\n %%%%%.%.%:%.%%%%%%%%.%.%%%%%%%%%%%%.%:%.%:#%%%% \r\n .:::%:%:%:%...:..::.:% .....::. ...:%:%.%:%:.:. \r\n %%%%#.%.%.%%%%%%%%%%%%.*.%%%%%%.%%%%%.%:%.%%%%% \r\n.%..:::@:@..::::...:::....%..::%.%-::..%.%:.:..%.\r\n.%.%##%#.%%%#%#%# %%#%%%%.%.%%%%.%#%%%.%.%%%%%.%.\r\n.#.%:::......::-%.%:::..%:%.%::. .:.:%:%:.:..%.%.\r\n.% %%%%%%%%.%%%%%.%%%%%.%:%.%%%%.%%%%%.%%%%%.#.#.\r\n.% .::::::%:@:.:. ..::%.%:% ..:%.%-.:. .:.:%:#.%.\r\n.%.%%%%##%%.%%#%#.%%%%#.%:%.%%%# #%%%%.%%%%%.#.%.\r\n.%.%:...... ...:%.@:....%:%.@:.. ...:%:@:....%.%.\r\n.%.#%%#%%%%.%%%%% %%%%%.%:#.%%%%%%%%%%.%%%#%%%.%.\r\n.%..::::::%:%:::..::.-%.%:%..:.:.:::.....:::.:.%.\r\n %%%%%%%%%%.%%%%%%%%%%%.%.%%%%%%%%%%%%%%%%%%%%@% \r\n  ........  .......... .% .....................  ";

            returnValue = returnValue.Replace(".", " ");
            returnValue = returnValue.Replace(":", " ");
            returnValue = returnValue.Replace("%", "#");
            returnValue = returnValue.Replace("@", "#");
            returnValue = returnValue.Replace("-", " ");
            returnValue = returnValue.Replace("*", "#");

            string[] lines = returnValue.Split("\r\n");

            bool[,] maze = new bool[lines.Length, lines[0].Length];

            for(int row = 0; row < maze.GetLength(0); row++)
            {
                for(int col = 0; col < maze.GetLength(1); col++)
                {
                    maze[row, col] = (lines[row][col] == ' ') ? true : false;
                }
            }

            return maze;

        }


        public static Node GetSmallestNode(List<Node> list)
        {
            Node minimum = list[0];

            foreach(Node node in list)
            {
                if (node.CurrentDistance < minimum.CurrentDistance)
                {
                    minimum = node;
                }
            }

            return minimum;
        }
    }
}
