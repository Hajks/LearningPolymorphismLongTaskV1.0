using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPolymorphismLongTaskV1._0
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        RoomWithDoor kitchen;
        RoomWithDoor livingRoom;
        Room dinningRoom;
        Outside garden;


        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToNewLocation(livingRoom);
          
        }
        private void CreateObjects()
        {
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "drzwi dębowe z mosiężną klamką");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "drzwi zasuwane");
            garden = new Outside("Ogród", false);
            kitchen = new RoomWithDoor("Kuchnia", "głowa deadpoola jako stojak na noże", "drzwi dębowe z mosiężną klamką");
            livingRoom = new RoomWithDoor("Salon", "ogromny obraz z Cirillą z wiedźmina", "drzwi zasuwane");
            dinningRoom = new Room("Jadalnia", "stary biały stół");

            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { frontYard, backYard };
            kitchen.Exits = new Location[] { livingRoom };
            livingRoom.Exits = new Location[] { dinningRoom };
            dinningRoom.Exits = new Location[] { kitchen, livingRoom };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToNewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            listBox.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                listBox.Items.Add(currentLocation.Exits[i].Name);
            }
           
            listBox.SelectedIndex = 0;
            descriptionBox.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor)
                goThroughDoor.Visible = true;
            else
                goThroughDoor.Visible = false;

        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(currentLocation.Exits[listBox.SelectedIndex]);
        }

        private void goThroughDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToNewLocation(hasDoor.DoorLocation);
        }
    }
}
