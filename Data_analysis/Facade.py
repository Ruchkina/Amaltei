from multiprocessing import Value
import pandas as pd
from DataExtractor import DataExtractor
from Metrics import Metrics

class Facade:

    def __init__(self, follower_path, subsciption_path):
        self.data = DataExtractor(follower_path, subsciption_path).Data_Extraction()
        self.metrics = Metrics(self.data)

    def Gender_Ratio(self, party_id):
        gender_ratio = self.metrics.Gender_Ratio(party_id)
        return gender_ratio

    def Occupation_Ratio(self, party_id):
        occupation_ratio = self.metrics.Occupation_Ratio(party_id)
        return occupation_ratio
    
    def Life_Main_Ratio(self, party_id):
        life_main_ratio = self.metrics.Life_Main_Ratio(party_id)
        return life_main_ratio

    def Age_Ratio(self, party_id):
        age_ratio = self.metrics.Age_Ratio(party_id)
        return age_ratio

    def Relation_Ratio(self, party_id):
        relation_ratio = self.metrics.Relation_Ratio(party_id)
        return relation_ratio

    def Political_Ratio(self, party_id):
        political_ratio = self.metrics.Political_Ratio(party_id)
        return political_ratio
    
    def Create_Data_For_Party(self, party_id):
        dict = {**(self.Gender_Ratio(party_id)), **(self.Age_Ratio(party_id)), 
        **(self.Occupation_Ratio(party_id)), **(self.Life_Main_Ratio(party_id)), 
        **(self.Relation_Ratio(party_id)), **(self.Political_Ratio(party_id)), **(self.Cities(party_id)) }
        return dict
        
    def Search_Max_Value_For_Portret(self, party_id):
        max_values = self.metrics.Surch_Max_Value_For_Portret(party_id)
        return max_values
    
    def Cities(self, party_id):
        cities = self.metrics.Cities(party_id)
        return cities
    
    def Output_data(self, dictmy, path_csv, path_excel):
        df = pd.DataFrame.from_records(dictmy).fillna(0)
        df.index = df.index + 1
        df.to_csv(path_csv)
        df.to_excel(path_excel)
        #print(df)
        