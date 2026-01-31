/// <summary>
/// This queue is circular. When people are added via AddPerson, they are added
/// to the back of the queue (FIFO). When GetNextPerson is called, the person
/// is dequeued and returned. If the person still has turns remaining (or has
/// infinite turns), they are re-enqueued.
/// </summary>
public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    /// <summary>
    /// Add a person to the queue.
    /// </summary>
    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue.
    /// </summary>
    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        Person person = _people.Dequeue();

        // Infinite turns: 0 or less → always re-enqueue, never modify turns
        if (person.Turns <= 0)
        {
            _people.Enqueue(person);
        }
        // Finite turns greater than 1 → decrement and re-enqueue
        else if (person.Turns > 1)
        {
            person.Turns--;
            _people.Enqueue(person);
        }
        // If Turns == 1 → last turn used, do NOT re-enqueue

        return person;
    }

    public override string ToString()
    {
        return _people.ToString();
    }
}
