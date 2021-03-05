#include <stdio.h>
#include <string.h>
#include <stdlib.h>

struct player_t {
	char name[10];
	int poreden_num;
};
struct game_t {
	int curr_round;
	struct player_t* arr;
	int board[16];
	int size;
};

int roll_die()
{
	int arr[] = { 1,2,3,4,5,6 };
	int num = arr[rand() % 6];
	return num;

}
void move_player(struct game_t* game, struct player_t* player)
{
	//game->arr = malloc(4*sizeof(struct player_t));
	int por_num = player->poreden_num;
	int is_occupied = 0;
	int moved_pos = roll_die();
	printf("DICE:NOM:%d:%dpos\n", player->poreden_num, moved_pos);
	for (int i = 0; i < 16; i++)
	{
		if (player->poreden_num == game->board[i])
		{
			game->board[i] = 0;

			for (int j = 0; j < game->size; j++)
			{
				if ((game->board[i + moved_pos] == game->arr[j].poreden_num) || (game->board[((i + moved_pos) - 16)] == game->arr[j].poreden_num))
				{
					for (int k = 0; k < 16; k++)
					{
						if (game->board[k] == game->arr[j].poreden_num)
						{
							game->board[k] = 0;
						}
					}

					//free(game->arr+j);
					for (int z = j; z < game->size; z++)
					{
						game->arr[z] = game->arr[z + 1];
					}
					game->size--;

					//free(game->arr[3]);



					game->arr = realloc(game->arr, game->size * sizeof(struct player_t));



					//memmove(game->arr+j,game->arr+j+1,(3-j)*sizeof(int));
					//is_occupied = 1;
					//struct player_t *tmp = game->arr[j+1];

					//arr[j]=tmp;
					break;
				}
			}


			//if(is_occupied==0)
			//{
			if ((i + moved_pos) >= 16)
			{
				int index = (i + moved_pos) - 16;
				game->board[index] = por_num;
				break;
			}
			else
			{
				game->board[i + moved_pos] = por_num;
				break;
			}
			//   }    
		}

	}


}

int play_round(struct game_t* game)
{
	game->curr_round++;

	//	
	for (int i = 0; i < 16; i++)
	{
		printf("%d\n", game->board[i]);
	}
	printf("\n");

	for (int k = 0; k < game->size; k++)
	{
		printf("%d %s %d\n", k, game->arr[k].name, game->arr[k].poreden_num);
	}

	//
	printf("Starting round %d\n", game->curr_round);
	for (int i = 0; i < game->size; i++)
	{

		move_player(game, game->arr + i);
		if (game->size == 1)
		{
			return 1;
		}

	}
	if (game->size >= 2)
	{
		return 0;
	}

}
void play_game(struct game_t* game)
{
	int result = 0;
	while (result != 1)
	{
		result = play_round(game);

	}


}


int main()
{
	//struct player_t fir={"Gosho",0};
	//fir.poreden_num = roll_die();
	//printf("%d",fir.poreden_num);

	//struct game_t game;
	   // game.curr_round = 1;



	   // game.arr=malloc(4*sizeof(struct player_t));


	struct player_t player1 = { "Vladi", 1 };
	struct player_t player2 = { "Gosho", 2 };
	struct player_t player3 = { "Mitko", 3 };
	struct player_t player4 = { "Ivan", 4 };

	struct player_t* players = malloc(4 * sizeof(struct player_t));
	players[0] = player1;
	players[1] = player2;
	players[2] = player3;
	players[3] = player4;



	struct game_t game = { 0, players };
	game.size = 4;
	game.arr = players;
	// struct player_t players[4] = {{"First",1},{"Second",2},{"Third",3},{"Fourth",4}};
	// game.arr = players;

	game.board[0] = 1;
	game.board[1] = 2;
	game.board[2] = 3;
	game.board[3] = 4;
	game.board[4] = 0;
	game.board[5] = 0;
	game.board[6] = 0;
	game.board[7] = 0;
	game.board[8] = 0;
	game.board[9] = 0;
	game.board[10] = 0;
	game.board[11] = 0;
	game.board[12] = 0;
	game.board[13] = 0;
	game.board[14] = 0;
	game.board[15] = 0;


	///MOVING PLAYERS    
	  //move_player(&game, &game.arr[3]);
   //   move_player(&game, &game.arr[1]);
	//  move_player(&game, &game.arr[1]);
	 // move_player(&game, &game.arr[1]);

	 // for(int j=0;j<   	

/////ROUND

	//printf("Resultat ot rounda:%d\n",play_round(&game));	



/////GAME

	printf("Game:\n");
	play_game(&game);


	for (int i = 0; i < 16; i++)
	{
		printf("%d\n", game.board[i]);
	}
	printf("\n");

	for (int k = 0; k < game.size; k++)
	{
		printf("%d %s %d\n", k, game.arr[k].name, game.arr[k].poreden_num);
	}





	return 0;




}

