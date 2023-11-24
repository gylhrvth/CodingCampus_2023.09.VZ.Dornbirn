using System;
using System.Collections.Generic;
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


            for(int row = 0; row < field.GetLength(0); row++)
            {
                for(int col = 0; col < field.GetLength(1); col++)
                {
                    bool foundSomething = false;
                    foreach(Node toDraw in solution)
                    {
                        if (row == toDraw.yCoord && col == toDraw.xCoord)
                        {
                            Console.Write("O ");
                            foundSomething = true;
                            break;
                        }
                    }
                    if (!foundSomething) Console.Write((field[row, col]) ? "  " : "##");
                }
                Console.WriteLine();
            }


            Console.SetCursorPosition(2*startNode.xCoord, startNode.yCoord);
            Console.Write("S");
            Console.SetCursorPosition(2*endNode.xCoord, endNode.yCoord);
            Console.Write("E");

            Console.Write(solution.Count());

            Console.Read();

        }



        public static List<Node> Dijkstra(Node start, Node end, List<Node> setting)
        {
            Dictionary<Node, Node> previousNeighbor = new Dictionary<Node, Node>();
            previousNeighbor[start] = start;
            List<Node> unvisited = new List<Node>();

            foreach(Node node in setting)
            {
                unvisited.Add(node);
            }

            start.SetDistance(0);
            unvisited.Remove(start);

            Node currentNode = start;

            while (unvisited.Contains(end))
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
                    if (Math.Abs(node.xCoord - potentialNeighbor.xCoord) == 1 ^ Math.Abs(node.yCoord - potentialNeighbor.yCoord) == 1)
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
    }
}
