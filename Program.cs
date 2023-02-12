using System;
using System.Collections.Generic;
using System.Threading;

namespace StillAlive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int octave = 1;

            List<Note> notes = new List<Note>();
            //this was a triumph
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "This "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "was "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "a "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "thri"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.HALF, "umph." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //im making a note here huge success
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "I'm "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "ma"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "king "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "a "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "note "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.HALF, "here: "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.THIRD, "HUGE "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "SUC"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.HALF, "CESS." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //its hard to overstate my satisfaction
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.THIRD, "It's "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "hard "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "to "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.HALF, "o"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "ver"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('j', octave), Duration.THIRD, "state "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.FIFTH, "my "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.HALF, "sa"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.FIFTH, "ti"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.THIRD, "sfac"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.HALF, "tion." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //aperture science
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "A"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "per"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "ture "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "Sci"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.HALF, "ence:" + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //we do what we must because we can
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "We "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "do "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "what "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "we "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.HALF, "must "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "be"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.HALF, "cause "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.FIFTH, "we "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.HALF, "can." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //for the good of all of us
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "For "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "the "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.HALF, "good "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "of "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('j', octave), Duration.THIRD, "all "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.FIFTH, "of "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "us.." + Environment.NewLine));

            //except the ones who are dead
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.FIFTH, "ex"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "cept "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "the "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "ones "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "who "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "are "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.QUARTER, "DEAD." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.THIRD, null));

            //but theres no sense crying over every mistake
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "But "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('y', octave), Duration.SIXTH, "there's "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "no "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "sense "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "cry"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "ing "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "o"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "ver "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "eve"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "ry "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "mis"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "take." + Environment.NewLine));

            //you just keep on trying till you run out of cake
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "You "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('y', octave), Duration.SIXTH, "just "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "keep "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "on "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "try"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "ing "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "till "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "you "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "run "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "out "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "of "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "cake." + Environment.NewLine));

            //and then science gets done
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "And "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "then "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('2', octave), Duration.SIXTH, "sci"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('2', octave), Duration.SIXTH, "ence "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.THIRD, "gets "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.THIRD, "done.." + Environment.NewLine));

            //and you make a neat gun
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "you "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "make "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "a "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.THIRD, "neet "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "gun.." + Environment.NewLine));

            //for the people who are still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "for "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "the "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "pe"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "ople "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "who "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "are "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "ali"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "ve." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.WHOLE, null));

            //im not even angry
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "I'm ", true));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "not "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "ev"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "en "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "an"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.HALF, "gry.." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //im being so sincere with now
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "I'm "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "be"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "ing "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.HALF, "so "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "sin"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.HALF, "cere "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "right "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.HALF, "now." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //even tho you broke my heart and killed me
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "E"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "ven "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.HALF, "tho "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "you "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('j', octave), Duration.THIRD, "broke "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.FIFTH, "my "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.HALF, "heart "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.FIFTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.THIRD, "killed "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.HALF, "me.." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //and tore me to pieces
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "tore "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "me "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "to "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "pie"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.THIRD, "ces.." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //and threw every piece in to a fire
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "threw "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "eve"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "ry "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.HALF, "piece "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "in"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.HALF, "to "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.FIFTH, "a "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.HALF, "fire." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //as they burned it hurt because
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "As "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "they "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.HALF, "burned "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "it "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('j', octave), Duration.THIRD, "hurt "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.FIFTH, "be"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "cause" + Environment.NewLine));

            //i was so happy for you
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.FIFTH, "I "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "was "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "so "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "hap"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "py "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "for "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.QUARTER, "you." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.THIRD, null));

            //now these points of data make a beautiful line
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "Now "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('y', octave), Duration.SIXTH, "these "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "points "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "of "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "da"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "ta "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "make "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "a "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "bea"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "uti"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "ful "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "line," + Environment.NewLine));

            //and we're out of beta we're releasing on time
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('y', octave), Duration.SIXTH, "we're "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "out "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "of "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "be"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "ta "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "we're "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "re"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "lea"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "sing "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "on "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "time." + Environment.NewLine));

            //so im glad i got burned
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "So "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "I'm "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('2', octave), Duration.SIXTH, "GLad "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('2', octave), Duration.SIXTH, "I "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.THIRD, "got "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.THIRD, "burned," + Environment.NewLine));

            //think of all the things we learned
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "think "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "of "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "all "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "the "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "things "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "we "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "learned" + Environment.NewLine));

            //for the people who are still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "for "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "the "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "peo"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "ple "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "who "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "are "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "a"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.HALF, "live." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.WHOLE, null));

            //go ahead and leave me
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "Go ", true));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "ahead "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "leave "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.HALF, "me." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //i think i prefer to stay inside
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "I "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "think "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "I "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "pre"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.HALF, "fer "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "to "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.HALF, "stay "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.FIFTH, "in"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.HALF, "side." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //maybe go find someone else to help you
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "May"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "be "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.HALF, "go "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "find "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('j', octave), Duration.THIRD, "some"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.FIFTH, "one "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.HALF, "else "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.FIFTH, "to "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.THIRD, "help "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.HALF, "you.." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //maybe black mesa
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "may"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "be "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "Black "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "Me"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.THIRD, "sa." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //that was a joke ahah fat chance
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "THAT "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "WAS "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "A "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.HALF, "JOKE.."));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, " AH "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.HALF, "AH.. "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.FIFTH, "FAT "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.HALF, "CHANCE." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));

            //anyway this cake is great
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "A"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.FIFTH, "ny"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.HALF, "way "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "this "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('j', octave), Duration.THIRD, "cake "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.FIFTH, "is "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "great!" + Environment.NewLine));

            //its so delicious and moist
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.FIFTH, "It's "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "so "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "de"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "li"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "cious "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.QUARTER, "moist." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.THIRD, null));

            //look at me still talking when theres science to do
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "Look "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('y', octave), Duration.SIXTH, "at "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "me "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "tal"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "king "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "when "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "there's "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "sci"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "ence "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "to "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "do." + Environment.NewLine));

            //when i look out there it makes me glad im not you
            notes.Add(new Note(ToneHelper.GetToneFromKey('g', octave), Duration.SIXTH, "When "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('y', octave), Duration.SIXTH, "I "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.THIRD, "look "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "out "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "there "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "it "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "makes "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "me "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "GLaD "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "I'm "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "not "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "you." + Environment.NewLine));

            //ive experiments to run
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "I've "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "ex"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('2', octave), Duration.SIXTH, "pe"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('2', octave), Duration.SIXTH, "ri"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "ments "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "to "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.THIRD, "run.." + Environment.NewLine));

            //there is research to be done
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "there "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "is "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "re"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "search "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('à', octave), Duration.SIXTH, "to "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "be "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.THIRD, "done.." + Environment.NewLine));

            //on the people who are still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "on "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('u', octave), Duration.SIXTH, "the "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('k', octave), Duration.SIXTH, "peo"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "ple "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "who "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "are "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.SIXTH, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.SIXTH, "a"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('p', octave), Duration.HALF, "live." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.THIRD, null));

            //and believe me i am still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "And ", true));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "be"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('5', octave), Duration.SIXTH, "lieve "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "me "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "I "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "am "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "a"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.HALF, "live." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.QUARTER, null));

            //im doing science and im still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "I'm "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "do"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "ing "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('5', octave), Duration.SIXTH, "sci"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "ence "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "I'm "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "a"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.HALF, "live." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.QUARTER, null));

            //i feel fantastic and im still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "I "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "feel "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "fan"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('5', octave), Duration.SIXTH, "tas"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "tic "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "and "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "I'm "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "a"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.HALF, "live." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.QUARTER, null));

            //while youre dying ill be still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "While "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "you're "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('5', octave), Duration.SIXTH, "dy"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "ing "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "I'll "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "be "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "a"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.HALF, "live." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.QUARTER, null));

            //and when youre dead i will be still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "And "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "when "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "you're "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('5', octave), Duration.SIXTH, "dead "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "I "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "will "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('l', octave), Duration.THIRD, "be "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('ò', octave), Duration.SIXTH, "still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "a"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.HALF, "live." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.QUARTER, null));

            //still alive, still alive
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "Still "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.SIXTH, "a"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('3', octave), Duration.HALF, "live.." + Environment.NewLine));
            notes.Add(new Note(Tone.REST, octave, Duration.HALF, null));
            notes.Add(new Note(ToneHelper.GetToneFromKey('1', octave), Duration.SIXTH, "STILL "));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.SIXTH, "A"));
            notes.Add(new Note(ToneHelper.GetToneFromKey('0', octave), Duration.HALF, "LIVE." + Environment.NewLine));

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var note in notes)
                note.Play();
            Console.ForegroundColor = ConsoleColor.Gray;
            //while (true)
            //{
            //    var key = Console.ReadKey();
            //    //var en = Enum.GetValues(typeof(Tone)).OfType<Tone>().Where(t => t.ToString().ToLowerInvariant() == key.KeyChar.ToString().ToLowerInvariant()).FirstOrDefault();

            //    if (key.KeyChar.ToString().ToLowerInvariant() == "z")
            //        Console.Clear();

            //    var tone = ToneHelper.GetToneFromKey(key, octave);
            //    if (tone.tone != Tone.REST)
            //    {
            //        var note = new Note(tone.tone, tone.octave, Duration.QUARTER);
            //        note.Play();
            //    }
            //}
        }
    }

    internal class Note
    {
        private int frequency;
        private int octave;
        private int duration;
        private string? lyrics;
        private bool? clearScreen;
        public Note(int frequency, int octave, int duration, string? lyrics, bool? clearScreen = null)
        {
            this.frequency = frequency;
            this.octave = octave;
            this.duration = duration;
            this.lyrics = lyrics;
            this.clearScreen = clearScreen;
        }
        public Note(Tone tone, int octave, Duration duration, string? lyrics, bool? clearScreen = null)
        {
            this.frequency = (int)tone;
            this.octave = octave;
            this.duration = (int)duration;
            this.lyrics = lyrics;
            this.clearScreen = clearScreen;
        }
        public Note((Tone tone, int octave) toneAndOctave, Duration duration, string? lyrics, bool? clearScreen = null)
        {
            this.frequency = (int)toneAndOctave.tone;
            this.octave = toneAndOctave.octave;
            this.duration = (int)duration;
            this.lyrics = lyrics;
            this.clearScreen = clearScreen;
        }
        public void Play()
        {
            if (this.frequency != 0)
            {
                if (this.clearScreen.HasValue && this.clearScreen.Value)
                    Console.Clear();
                if (lyrics != null)
                    Console.Write(this.lyrics);
                Console.Beep(this.frequency * this.octave, this.duration);
            }
            else
                Thread.Sleep(this.duration);
        }
    }
    public static class ToneHelper
    {
        public static (Tone tone, int octave) GetToneFromKey(ConsoleKeyInfo key, int octave)
        {
            var toSender = GetToneFromKey(key.KeyChar, octave);
            return toSender;
        }
        public static (Tone tone, int octave) GetToneFromKey(char key, int octave)
        {
            var toSender = (Tone.REST, octave);
            var keyString = key.ToString().ToLowerInvariant();
            if (keyString == "a")
                toSender = (Tone.C, octave);
            else if (keyString == "w")
                toSender = (Tone.Csharp, octave);
            else if (keyString == "s")
                toSender = (Tone.D, octave);
            else if (keyString == "e")
                toSender = (Tone.Dsharp, octave);
            else if (keyString == "d")
                toSender = (Tone.E, octave);
            else if (keyString == "f")
                toSender = (Tone.F, octave);
            else if (keyString == "t")
                toSender = (Tone.Fsharp, octave);
            else if (keyString == "g")
                toSender = (Tone.G, octave);
            else if (keyString == "y")
                toSender = (Tone.Gsharp, octave);

            else if (keyString == "h")
                toSender = (Tone.A, octave * 2);
            else if (keyString == "u")
                toSender = (Tone.Asharp, octave * 2);
            else if (keyString == "j")
                toSender = (Tone.B, octave * 2);

            else if (keyString == "k")
                toSender = (Tone.C, octave * 2);
            else if (keyString == "o")
                toSender = (Tone.Csharp, octave * 2);
            else if (keyString == "l")
                toSender = (Tone.D, octave * 2);
            else if (keyString == "p")
                toSender = (Tone.Dsharp, octave * 2);
            else if (keyString == "ò")
                toSender = (Tone.E, octave * 2);
            else if (keyString == "à")
                toSender = (Tone.F, octave * 2);


            else if (keyString == "0")
                toSender = (Tone.Fsharp, octave * 2);
            else if (keyString == "1")
                toSender = (Tone.G, octave * 2);
            else if (keyString == "2")
                toSender = (Tone.Gsharp, octave * 2);
            else if (keyString == "3")
                toSender = (Tone.A, octave * 4);
            else if (keyString == "4")
                toSender = (Tone.Asharp, octave * 4);
            else if (keyString == "5")
                toSender = (Tone.B, octave * 4);
            else if (keyString == "6")
                toSender = (Tone.C, octave * 4);
            else if (keyString == "7")
                toSender = (Tone.Csharp, octave * 4);
            else if (keyString == "8")
                toSender = (Tone.D, octave * 4);
            else if (keyString == "9")
                toSender = (Tone.D, octave * 4);

            return toSender;
        }
    }
    public enum Tone
    {
        REST = 0,
        GbelowC = 196,
        A = 220,
        Asharp = 233,
        B = 247,
        C = 262,
        Csharp = 277,
        D = 294,
        Dsharp = 311,
        E = 330,
        F = 349,
        Fsharp = 370,
        G = 392,
        Gsharp = 415,
    }
    public enum Duration
    {
        WHOLE = 1600,
        HALF = WHOLE / 2,
        THIRD = WHOLE / 3,
        QUARTER = WHOLE / 4,
        FIFTH = WHOLE / 5,
        SIXTH = WHOLE / 6,
        EIGHTH = WHOLE / 8,
        SIXTEENTH = WHOLE / 16,
    }
}