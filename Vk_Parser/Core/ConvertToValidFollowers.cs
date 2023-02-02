using DatabaseModels;


namespace Core
{
    public static class ConvertToValidFollowers
    {
        public static Follower? Convert(Response UserInfo)
        {
            if (UserInfo == null)
                return null;

            return new Follower(
                id : UserInfo.id,
                sex: UserInfo.sex,
                city : UserInfo.city.Id,
                education : UserInfo.university,
                occupation : UserInfo.occupation.Type,
                activities : UserInfo.activities,
                bdate: ConvertBirth.GetBirthYear(UserInfo),
                personal_political : UserInfo.personal.Political,
                personal_religion : UserInfo.personal.Religion,
                personal_life_main : UserInfo.personal.Life_main,
                personal_people_main : UserInfo.personal.People_main,
                military : UserInfo.military.Unit_id,
                home_town : UserInfo.home_town,
                relation : UserInfo.relation,
                faculty : UserInfo.faculty
            );
        }
    }
}
