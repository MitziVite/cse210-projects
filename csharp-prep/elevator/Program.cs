Elevator firstelevator = new Elevator();
for(int i=0; i <= 30; i++){
    Floor newFloor = new Floor(i);
    firstelevator.AddFloorNumber(newFloor);
}

firstelevator.ShowFloor();