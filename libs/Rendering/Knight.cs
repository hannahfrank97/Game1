namespace libs;

public class Knight : GameObject {

    public Knight () : base(){
        this.Type = GameObjectType.Knight;
        this.CharRepresentation = '♞';
        this.Color = ConsoleColor.DarkGreen;
    }
public override void Move(int dx, int dy)
{
 if (_focusedObject != null && _focusedObject.Type == GameObjectType.Knight) {

    ((Math.Abs(dx) == 2 && Math.Abs(dy) == 1) || (Math.Abs(dx) == 1 && Math.Abs(dy) == 2)) 
 }
    else 
    {
        //Console.WriteLine("Invalid move for a knight");
    }
}


}