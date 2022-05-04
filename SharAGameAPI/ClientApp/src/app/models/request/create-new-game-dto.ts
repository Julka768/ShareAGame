import { GamePlatfromEnum } from '../enums/game-platform-enum';

export interface CreateNewGameDto {
  name: string;
  isDigital: boolean;
  releaseDate: Date;
  imageUrl: string;
  publisherId: string;
  gamePlatform: GamePlatfromEnum;
}
