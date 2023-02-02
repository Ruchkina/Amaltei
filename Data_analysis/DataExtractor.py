import pandas as pd

class DataExtractor:
    def __init__(self, file_path_Follower, file_path_Subsciption):
        self.file_path_Follower = file_path_Follower
        self.file_path_Subsciption = file_path_Subsciption

    def Data_Extraction(self):
        followers_df = pd.read_csv(self.file_path_Follower).sort_values(by="Id")
        subscription_df = pd.read_csv(self.file_path_Subsciption).sort_values(by='FollowerId')
        followers_df['PartyId'] = subscription_df.PartyId.values
        followers_df = followers_df.sort_values(by= 'PartyId', ignore_index=True)   
        return followers_df
