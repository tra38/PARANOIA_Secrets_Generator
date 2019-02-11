using System;
using System.Collections.Generic;

public static class CharacterGenerator
{
  public static Func<string> RandomSociety =
  Generator.GenerateRule<string>
  (
    new List<string>
    {
      "Anti-Mutant", "Computer Phreaks", "Communist", "Corpore Metal", "Death Leopard", "FCCC-P", "Frankenstein Destroyers", "Free Enterprise", "Humanist", "Illuminati", "Mystics", "Pro Tech", "Psion", "PURGE", "Romantics", "Sierra Club", "Spy For Another Alpha Complex", "Program Group"
    }
  );

  public static Func<string> RandomMutation =
  Generator.GenerateRule<string>
  (
    new List<string>
    {
      "Machine Empathy", "Adhesive Skin", "Adrenalin Control", "Bureaucratic Intuition", "Charm", "Death Simulation", "Deep Thought", "Electroshock", "Empathy", "Energy Field", "Hypersenses", "Matter Eater", "Mechanical Intuition", "Mental Blast", "Pyrokinesis", "Regeneration", "Rubbery Bones", "Toxic Metabolism", "Uncanny Luck", "Ventriloquist"
    }
  );

}