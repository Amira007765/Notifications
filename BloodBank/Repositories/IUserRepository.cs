public interface IUserRepository
{
    User? GetUserById(int userId); // تعديل التعريف ليكون Nullable
    void UpdateUser(User user);
}
