import uno

def getDoubleOf(data):
     '''Simple demo-function duplicating plain cell values 1->2, "A"->"AA"     
     Thanks to the c.s.s.script.ArrayWrapper it works in array context as well. To be called through a 
     StarBasic wrapper.'''     
     # cheap msgbox in scripting context:     
     # raise Exception(repr(data))     
     if hasattr(data[0], '__iter__'):
         # two lists:
         rows = []
         wrapper = uno.createUnoStruct('com.sun.star.script.ArrayWrapper')
         # =A1:B2 passes a one-based array to a Basic function. Let's assume the same here:
         # (Apparently it makes no difference if IsZeroIndex or not)
         wrapper.IsZeroIndex = False
         for row in data:
             column = []
             for val in row:
                 try:
                     column.append(val * 2)
                 except:
                     column.append(None)
             rows.append(tuple(column))
         # returning the mere list of list fails:
         # return tuple(rows)
         # here comes the wrapper into play:
         wrapper.Array = tuple(rows)
         return wrapper 
         
     elif hasattr(data, '__abs__'):
         return data *2
     else:         
        return None 