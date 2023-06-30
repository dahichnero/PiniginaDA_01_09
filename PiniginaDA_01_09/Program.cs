// See https://aka.ms/new-console-template for more information
using PiniginaDA_01_09;

RoadWorks roadWorks = new RoadWorks(120.3,2000.5,23.7);
roadWorks.PrintAboutRoad();
roadWorks.PrintAboutQuality();

RoadWorksChild worksChild = new RoadWorksChild(200.3, 3050.6, 45.5, 29);
worksChild.PrintAboutRoad();
worksChild.PrintAboutQuality();