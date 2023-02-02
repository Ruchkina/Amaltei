import pandas as pd
from Facade import Facade
import Constants


f = Facade(Constants.PATH_FOLLOWER, Constants.PATH_SUBSCIPTION)

Party1 = f.Create_Data_For_Party(1)
Party2 = f.Create_Data_For_Party(2)
Party3 = f.Create_Data_For_Party(3)
Party4 = f.Create_Data_For_Party(4)
Party5 = f.Create_Data_For_Party(5)
Party6 = f.Create_Data_For_Party(6)

dict_Party = [Party1, Party2, Party3, Party4, Party5, Party6]

f.Output_data(dict_Party, Constants.PATH_METRICS_CSV, Constants.PATH_METRICS_EXCEL)

max_value_Party1 = f.Search_Max_Value_For_Portret(1)
max_value_Party2 = f.Search_Max_Value_For_Portret(2)
max_value_Party3 = f.Search_Max_Value_For_Portret(3)
max_value_Party4 = f.Search_Max_Value_For_Portret(4)
max_value_Party5 = f.Search_Max_Value_For_Portret(5)
max_value_Party6 = f.Search_Max_Value_For_Portret(6)

dict_max_value_Party = [max_value_Party1, max_value_Party2, max_value_Party3, max_value_Party4, max_value_Party5, max_value_Party6]

f.Output_data(dict_max_value_Party, Constants.PATH_PORTRAITS_CSV, Constants.PATH_PORTRAITS_EXCEL)




        
