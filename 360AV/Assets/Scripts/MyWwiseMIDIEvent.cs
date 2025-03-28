using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWwiseMIDIEvent : MonoBehaviour
{
    [SerializeField] private AK.Wwise.Event SynthEvent;
    [SerializeField][Range(36,91)] private int note;

    public void PlayNote()
    {
        AkMIDIPostArray MIDIPostArrayBuffer = new AkMIDIPostArray(1);

        AkMIDIPost midiEvent = new AkMIDIPost();
        midiEvent.byType = AkMIDIEventTypes.NOTE_ON;
        midiEvent.byChan = 0;
        midiEvent.byOnOffNote = (byte)note;
        midiEvent.byVelocity = 127;
        midiEvent.uOffset = 0;

        MIDIPostArrayBuffer[0] = midiEvent;
        SynthEvent.PostMIDI(gameObject, MIDIPostArrayBuffer);
    }

    public void StopNote()
    {
        SynthEvent.StopMIDI(gameObject);
    }
    
    
}
