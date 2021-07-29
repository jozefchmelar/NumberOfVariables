# Get number of variables in a struct 


Isaac posted on LinkedIn a question

> I just have a quick question to see if this is possible. I have a struct in TwinCAT with a number of variables of different types (i.e. DINT, BOOL, etc.). For networking reasons, I need to programatically determine the number of variables in this struct to send in a UDP packet.
>
> I've tried the following with no success:
> - Using __VARINFO (does not provide the information I need)
> - Using SIZEOF (cannot be used, as variables could be different sizes)
> - Using PLC_ReadSymInfoByName (does not provide information I need)
>
> Any help would be greatly appreciated.
> 
> Thanks!
> Isaac

Please note that this is a proof of concept.

1. I created a PLC project, generated some struct with many variables.
2. Inxton builder created a C# Twin of the PLC
3. I used C# reflection, to get the number of variables in the struct
4. Write the values back to the PLC.

Even though I'm using Inxton, in this use case it's not neccessary to buy a licence to get the number of variables in a struct.

I  need a licence, to write to plc though, but a workourd is possible. 

If the struct changes, the PLC connector has to be rebuild. It's easy to define a target in the C# project to run the builder everytime a solution with TwinCAT project is rebuild.

It has it cons, but hey! it works. :) 


 
