from locale import normalize
import pandas as pd
import datetime
from DataExtractor import DataExtractor
from collections import Counter

class Metrics:
    def __init__(self, extracted_data):
        self.data = extracted_data
    
    def Persentage_Conversion(self, number,total):
        action1 = number/total
        action2 = 100 * action1
        res = round(action2,1)
        return res
    
    def Gender_Ratio(self, party_id):
        people = self.data.query('PartyId == @party_id').Id.count()
        woman = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Sex == 1').Id.count(), people)
        man = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Sex == 2').Id.count(),people)
        dict = {'W': woman, 'M': man}
        return dict

    def Occupation_Ratio(self, party_id):
        people = self.data.query('PartyId == @party_id & (Occupation == "university" | Occupation == "work" | Occupation == "school")').Id.count()
        university = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Occupation == "university"').Id.count(), people)
        work = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Occupation == "work"').Id.count(), people)
        school = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Occupation == "school"').Id.count(), people)
        dict = {'university': university, 'work': work, 'school': school}
        return dict
    
    def Life_Main_Ratio(self, party_id):
        people = self.data.query('PartyId == @party_id & Personal_life_main != 0 ' ).Id.count()
        famaly = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_life_main == 1').Id.count(), people)
        career_and_money = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_life_main == 2').Id.count(), people)
        fame_and_power = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_life_main == 8').Id.count(), people)
        entertainment = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_life_main == 3').Id.count(), people)
        science = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_life_main == 4').Id.count(), people)
        self_development = self.Persentage_Conversion(self.data.query('PartyId == @party_id & (Personal_life_main == 5 | Personal_life_main == 6 | Personal_life_main == 7 )').Id.count(), people)
        dict = {'famaly': famaly, 'career_and_money': career_and_money,'fame_and_power': fame_and_power,'entertainment': entertainment,'science': science, 'self_development':self_development}
        return dict

    def Age_Ratio(self,party_id):
        current_year = datetime.date.today().year
        people = self.data.query('PartyId == @party_id').Id.count()
        less_20 = self.Persentage_Conversion(self.data.query('PartyId == @party_id & ((@current_year - BirthDate) <= 20 )').Id.count(), people)
        _21_to_30 = self.Persentage_Conversion(self.data.query('PartyId == @party_id & ( 21 <= (@current_year - BirthDate) <= 30 )').Id.count(), people)
        _31_to_40 = self.Persentage_Conversion(self.data.query('PartyId == @party_id & ( 31 <= (@current_year - BirthDate) <= 40 )').Id.count(), people)
        _41_to_60 = self.Persentage_Conversion(self.data.query('PartyId == @party_id & ( 41 <= (@current_year - BirthDate) <= 60 )').Id.count(), people)
        over_61 = self.Persentage_Conversion(self.data.query('PartyId == @party_id & ( 61 <= (@current_year - BirthDate) < 90 )').Id.count(), people)
        dict = {'less_20': less_20,'_21_to_30': _21_to_30,'_31_to_40': _31_to_40, '_41_to_60': _41_to_60, 'over_61': over_61}
        return dict

    def Relation_Ratio(self, party_id):
        people = self.data.query('PartyId == @party_id & Relation != 0').Id.count()
        married = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Relation == 4').Id.count(), people)
        not_married = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Relation == 1').Id.count(), people)
        have_friend = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Relation == 2').Id.count(), people)
        civil_merriage = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Relation == 8').Id.count(), people)
        engagement = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Relation == 3').Id.count(), people)
        active_research = self.Persentage_Conversion(self.data.query('PartyId == @party_id & (Relation == 5 | Relation == 6 | Relation == 7)').Id.count(), people)
        dict = {'married': married, 'not_married': not_married,'have_friend': have_friend,'civil_merriage': civil_merriage,'engagement': engagement,'active_research': active_research}
        return dict

    def Political_Ratio(self,party_id):
        people = self.data.query('PartyId == @party_id & Personal_political != 0').Id.count()
        communists = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_political == 1').Id.count(), people)
        socialists = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_political == 2').Id.count(), people)
        moderate = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_political == 3').Id.count(), people)
        liberals = self.Persentage_Conversion(self.data.query('PartyId == @party_id & (Personal_political == 4 | Personal_political == 9)').Id.count(), people)
        conservatives = self.Persentage_Conversion(self.data.query('PartyId == @party_id & (Personal_political == 5 | Personal_political == 6 | Personal_political == 7)').Id.count(), people)
        indifferents = self.Persentage_Conversion(self.data.query('PartyId == @party_id & Personal_political == 8').Id.count(), people)
        dict = {'communists': communists, 'socialists': socialists,'moderate': moderate,'liberals': liberals,'conservatives': conservatives,'indifferents': indifferents}
        return dict

    def Cities(self,party_id):
        sorted_cities = self.data.query('PartyId == @party_id & City != 0')
        normalize_cities = 100 * round(sorted_cities.City.value_counts(normalize=True),3)
        return normalize_cities[:5].to_dict()

    def Surch_Max_Value_For_Portret(self, party_id):
        maXKeyGR = max(self.Gender_Ratio(party_id), key=self.Gender_Ratio(party_id).get)
        maXKeyOR = max(self.Occupation_Ratio(party_id), key=self.Occupation_Ratio(party_id).get)
        maXKeyMR = max(self.Life_Main_Ratio(party_id), key=self.Life_Main_Ratio(party_id).get)
        maXKeyRR = max(self.Relation_Ratio(party_id), key=self.Relation_Ratio(party_id).get)
        maXKeyPR = max(self.Political_Ratio(party_id), key=self.Political_Ratio(party_id).get)
        maXKeyC = max(self.Cities(party_id), key=self.Cities(party_id).get)
        maXKeyAR = max(self.Age_Ratio(party_id), key=self.Age_Ratio(party_id).get)
        dict = {'Gender':  maXKeyGR, 'Occupation': maXKeyOR, 'Life_Main_Ratio': maXKeyMR,
                'Relation_Ratio': maXKeyRR,'Political_Ratio': maXKeyPR,'Cities': maXKeyC, 'Age_Ratio': maXKeyAR}
        return dict
