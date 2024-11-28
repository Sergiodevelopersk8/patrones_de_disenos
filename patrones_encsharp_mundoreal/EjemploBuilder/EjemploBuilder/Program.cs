using EjemploBuilder;

IRobotBuilder robotBuilder = new RobotBuilder();

RobotDirector robotDirector = new RobotDirector(robotBuilder);

robotDirector.ConstructorRobot();
Robot robot = robotBuilder.GetRobot();

robot.DisplayRobotInfo();
