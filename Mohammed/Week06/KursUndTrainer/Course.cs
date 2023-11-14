using System;
namespace Mohammed.Week06.KursUndTrainer;

public class Course
{
	private string _Title;
	private DateTime _Start;
	private int _Length;
	private int _Price;
	private Person _Trainer;
	public Person Trainer
	{
		get => _Trainer;
		set => _Trainer = value;
	}

	private List<Person> Participants;

	public Course (string title, DateTime start, int length)
	{
		_Title = title;
		_Start = start;
		_Length = length;
		_Price = length;
		_Trainer = null;
	}

        public override string ToString()
        {
            return string.Format("Course : {0}. The trainer of this Course is{1}",
			_Title,
			(_Trainer != null)? _Trainer.Name: "N.N.");
        }
    }

