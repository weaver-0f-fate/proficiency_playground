namespace State;

public interface IOven
{
    public void Bake();
    public void HeatUp();
    public void CoolDown();
}

public class Oven : IOven
{
    private IOvenState CurrentState { get; set; }

    public Oven()
    {
        CurrentState = new ColdState(this);
    }

    public void Bake()
    {
        CurrentState.Bake();
    }

    public void HeatUp()
    {
        CurrentState.HeatUp();
    }

    public void CoolDown()
    {
        CurrentState.CoolDown();
    }

    private interface IOvenState
    {
        public void Bake();
        public void HeatUp();
        public void CoolDown();
    }

    private class ColdState : IOvenState
    {
        private readonly Oven _context;
        
        public ColdState(Oven context)
        {
            _context = context;
        }

        public void Bake()
        {
            throw new Exception("Oven is cold");
            
        }

        public void HeatUp()
        {
            Console.WriteLine("Oven is heating up.");
            _context.CurrentState = new ReadyState(_context);
        }

        public void CoolDown()
        {
            Console.WriteLine("Oven is already cold.");
        }
    }

    private class ReadyState : IOvenState
    {
        private readonly Oven _context;
        
        public ReadyState(Oven context)
        {
            _context = context;
        }

        public void Bake()
        {
            Console.WriteLine("Oven is cooking pizza");
            _context.CurrentState = new OverheatState(_context);
        }

        public void HeatUp()
        {
            Console.WriteLine("Oven is already ready to use.");
        }

        public void CoolDown()
        {
            Console.WriteLine("Oven is cooling down.");
            _context.CurrentState = new ColdState(_context);
        }
    }

    private class OverheatState : IOvenState
    {
        private readonly Oven _context;
        
        public OverheatState(Oven context)
        {
            _context = context;
        }

        public void Bake()
        {
            throw new Exception("Oven is overheated");
        }

        public void HeatUp()
        {
            Console.WriteLine("Oven is already overheated.");
        }

        public void CoolDown()
        {
            Console.WriteLine("Oven is cooling down.");
            _context.CurrentState = new ReadyState(_context);
        }
    }
}