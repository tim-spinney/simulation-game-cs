namespace GuiComponents;

public class A
{
    private int x;
    
    public int GetX() { return x; }
}

public class B : A
{
    private int y;

    public int Blah()
    {
        return GetX() + y;
    }
}

public class Student
{
}

public class Instructor : ChangeListener
{
    public void AssignToCourse(Course course)
    {
        course.Subscribe(this);
    }

    public void SomethingHappened()
    {
        
    }
}

public interface ChangeListener
{
    public void SomethingHappened();
}

public class ChangeNotifier
{
    private List<ChangeListener> listeners = new List<ChangeListener>();
    protected void Notify()
    {
        foreach (ChangeListener listener in listeners)
        {
            listener.SomethingHappened();
        }
    }

    public void Subscribe(ChangeListener listener)
    {
        listeners.Add(listener);
    }

    public void Unsubscribe(ChangeListener listener)
    {
        listeners.Remove(listener);
    }
}

public class Course : ChangeNotifier
{
    private List<Student> students = new List<Student>();

    public void Enroll(Student student)
    {
        students.Add(student);
        Notify();
    }
}